using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minecraft_Unindex
{
    public partial class frmUnindex : Form
    {
        public frmUnindex()
        {
            InitializeComponent();
        }

        static string Minecraft_Assets = Path.Combine(Settings.ApplicationData_Default, ".minecraft", "assets");
        static string Minecraft_Indexes = Path.Combine(Minecraft_Assets, "indexes");
        static string Minecraft_Objects = Path.Combine(Minecraft_Assets, "objects");

        private void frmUnindex_Shown(object sender, EventArgs e)
        {
            Refresh();
            chkIndex.Items.Clear();
            chkLocal.Items.Clear();
            chkExtension.Items.Clear();
            lblProgress.Text = "";

            btnUnindex.Enabled = false;
            btnAbort.Enabled = false;

            foreach (var item in RecursiveSearch.EnumerateFiles(Path.Combine(Settings.ApplicationData_Default, ".minecraft", "assets", "indexes"), "*.json", SearchOption.TopDirectoryOnly))
                chkIndex.Items.Add(Path.GetFileNameWithoutExtension(item), false);

            if (chkIndex.Items.Count == 0)
                lblProgress.Text = "Error: No index found.";
        }
        
        Index index;

        private void chkIndex_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btnUnindex.Enabled = false;
            
            chkLocal.Items.Clear();
            chkExtension.Items.Clear();

            try
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < chkIndex.Items.Count; i++)
                        if (i != e.Index)
                            chkIndex.SetItemChecked(i, false);

                    index = new Index(Path.Combine(Minecraft_Indexes, chkIndex.Items[e.Index].ToString() + ".json"));

                    if (index.Count == 0)
                    {
                        lblProgress.Text = "Error: The index is empty.";
                    }
                    if (index.Count > 0)
                    {
                        foreach (var item in index.Keys)
                            chkLocal.Items.Add(item, true);

                        foreach (var item in index.AllElements())
                            if (!chkExtension.Items.Contains(item.Extension))
                                chkExtension.Items.Add(item.Extension);

                        btnUnindex.Enabled = true;
                        
                    }
                }
            }
            catch
            {
                lblProgress.Text = "Error: The index as a invalid format.";
                index = null;
            }
        }

        private void btnUnindex_Click(object sender, EventArgs e)
        {
            elementUnindex.Clear();
            foreach (var item in index.AllElements())
                if (chkLocal.CheckedItems.Contains(item.Local) && chkExtension.CheckedItems.Contains(item.Extension))
                    elementUnindex.Add(item);

            prbProgress.Value = 0;
            prbProgress.Maximum = elementUnindex.Count;

            btnAbort.Enabled = true;
            btnUnindex.Enabled = false;
            bgwUnindex.RunWorkerAsync();
        }

        List<Element> elementUnindex = new List<Element>();

        private void btnAbort_Click(object sender, EventArgs e)
        {
            bgwUnindex.CancelAsync();
            btnAbort.Enabled = false;
        }

        private void bgwUnindex_DoWork(object sender, DoWorkEventArgs e)
        {
            string folder = Path.Combine(Settings.TempFolder, chkIndex.CheckedItems[0].ToString());

            foreach (Element item in elementUnindex)
            {
                if (bgwUnindex.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                bgwUnindex.ReportProgress(1, item.Name);
                try
                {
                    string hash = Path.Combine(Minecraft_Objects, item.Hash.Truncate(2), item.Hash);
                    if (File.Exists(hash))
                    {
                        string file = Path.Combine(folder, item.FullName);
                        Directory.CreateDirectory(Path.GetDirectoryName(file));
                        File.Copy(hash, file, true);
                    }
                }
                catch
                {
                }
                
                
            }
        }

        private void bgwUnindex_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbProgress.PerformStep();
            lblProgress.Text = prbProgress.Value + "/" + prbProgress.Maximum + " | " + e.UserState;

        }

        private void bgwUnindex_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                lblProgress.Text = "The operation was canceled.";
            else if (e.Error != null)
                lblProgress.Text = "Error: "+ e.Error.Message;
            else
            {
                lblProgress.Text = "The operation was completed.";
            }
            btnUnindex.Enabled = true;
            btnAbort.Enabled = false;
        }
    }
}

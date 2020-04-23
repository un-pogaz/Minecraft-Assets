namespace Minecraft_Unindex
{
    partial class frmUnindex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.btnUnindex = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.chkIndex = new System.Windows.Forms.CheckedListBox();
            this.chkLocal = new System.Windows.Forms.CheckedListBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkExtension = new System.Windows.Forms.CheckedListBox();
            this.bgwUnindex = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prbProgress
            // 
            this.prbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prbProgress.Location = new System.Drawing.Point(93, 237);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(398, 23);
            this.prbProgress.Step = 1;
            this.prbProgress.TabIndex = 0;
            // 
            // btnUnindex
            // 
            this.btnUnindex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnindex.Location = new System.Drawing.Point(497, 237);
            this.btnUnindex.Name = "btnUnindex";
            this.btnUnindex.Size = new System.Drawing.Size(75, 23);
            this.btnUnindex.TabIndex = 1;
            this.btnUnindex.Text = "Unindex";
            this.btnUnindex.UseVisualStyleBackColor = true;
            this.btnUnindex.Click += new System.EventHandler(this.btnUnindex_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(12, 237);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // chkIndex
            // 
            this.chkIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIndex.FormattingEnabled = true;
            this.chkIndex.Location = new System.Drawing.Point(3, 3);
            this.chkIndex.Name = "chkIndex";
            this.chkIndex.Size = new System.Drawing.Size(178, 190);
            this.chkIndex.TabIndex = 4;
            this.chkIndex.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkIndex_ItemCheck);
            // 
            // chkLocal
            // 
            this.chkLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLocal.FormattingEnabled = true;
            this.chkLocal.Location = new System.Drawing.Point(187, 3);
            this.chkLocal.Name = "chkLocal";
            this.chkLocal.Size = new System.Drawing.Size(178, 190);
            this.chkLocal.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProgress.Location = new System.Drawing.Point(93, 211);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(398, 23);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "label1";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.chkExtension, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkLocal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkIndex, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 196);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // chkExtension
            // 
            this.chkExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExtension.FormattingEnabled = true;
            this.chkExtension.Location = new System.Drawing.Point(371, 3);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(179, 190);
            this.chkExtension.TabIndex = 8;
            // 
            // bgwUnindex
            // 
            this.bgwUnindex.WorkerReportsProgress = true;
            this.bgwUnindex.WorkerSupportsCancellation = true;
            this.bgwUnindex.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUnindex_DoWork);
            this.bgwUnindex.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwUnindex_ProgressChanged);
            this.bgwUnindex.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUnindex_RunWorkerCompleted);
            // 
            // frmUnindex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 272);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnUnindex);
            this.Controls.Add(this.prbProgress);
            this.Name = "frmUnindex";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.frmUnindex_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Button btnUnindex;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.CheckedListBox chkIndex;
        private System.Windows.Forms.CheckedListBox chkLocal;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox chkExtension;
        private System.ComponentModel.BackgroundWorker bgwUnindex;
    }
}


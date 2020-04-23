using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Minecraft_Unindex
{
    internal class Index : Dictionary<string, List<Element>>
    {
        public Index(string path)
        {
            List<Element> lst = new List<Element>();
            foreach (JProperty item in JObjectCreate.Object(path).Property("objects").Properties())
            {
                Element element = new Element(item);

                if (!ContainsKey(element.Local))
                    Add(element.Local, new List<Element>());

                this[element.Local].Add(element);
            }
        }

        public IEnumerable<Element> AllElements()
        {
            foreach (var item in Values)
                foreach (var e in item)
                    yield return e;
        }
    }
    
    internal class Element
    {
        public string FullName { get; }
        public string Name { get { return System.IO.Path.GetFileName(FullName); } }
        public string Local { get { return FullName.Split('/', '\\')[0]; } }
        public string Extension { get { return System.IO.Path.GetExtension(FullName).ToLowerInvariant(); } }

        public string Hash { get; }
        public long Size { get; }

        public Element(JProperty property)
        {
            FullName = property.Name;
            Hash = property.Property("hash").Value.ToString();
            Size = long.Parse(property.Property("size").Value.ToString());
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}

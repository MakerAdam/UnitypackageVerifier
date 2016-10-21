using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPV.AssetItems
{

    public class Link
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string label { get; set; }
    }

    public class Publisher
    {
        public string id { get; set; }
        public string label { get; set; }
    }

    public class RootObject
    {
        public Link link { get; set; }
        public string pubdate { get; set; }
        public string description { get; set; }
        public string version { get; set; }
        public string version_id { get; set; }
        public Category category { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public Publisher publisher { get; set; }
        public string unity_version { get; set; }
    }
}

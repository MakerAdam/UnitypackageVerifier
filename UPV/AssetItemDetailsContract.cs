using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPV.AssetItemDetails
{
    public class Rating
    {
        public string count { get; set; }
        public string average { get; set; }
    }

    public class Category
    {
        public string long_url { get; set; }
        public string label_file { get; set; }
        public string tree_id { get; set; }
        public string label_english { get; set; }
        public string label { get; set; }
        public string id { get; set; }
        public string multiple { get; set; }
        public string short_url { get; set; }
    }

    public class Publisher
    {
        public string long_url { get; set; }
        public string support_email { get; set; }
        public string label_file { get; set; }
        public string label_english { get; set; }
        public string url { get; set; }
        public string label { get; set; }
        public string id { get; set; }
        public string short_url { get; set; }
        public object support_url { get; set; }
    }

    public class Link
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Image
    {
        public string width { get; set; }
        public string link { get; set; }
        public string src_size { get; set; }
        public string name { get; set; }
        public string height { get; set; }
        public string thumb { get; set; }
        public object caption { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string orig { get; set; }
    }

    public class Flags
    {
    }

    public class Keyimage
    {
        public string small { get; set; }
        public string icon { get; set; }
        public string big { get; set; }
        public string package_version_id { get; set; }
        public object medium { get; set; }
        public string icon75 { get; set; }
        public string icon25 { get; set; }
    }

    public class Price
    {
        public string DKK { get; set; }
        public string EUR { get; set; }
        public string JPY { get; set; }
        public string USD { get; set; }
    }

    public class Content
    {
        public string pubdate { get; set; }
        public string min_unity_version { get; set; }
        public string size { get; set; }
        public Rating rating { get; set; }
        public string url { get; set; }
        public string package_version_id { get; set; }
        public string id { get; set; }
        public Category category { get; set; }
        public string sizetext { get; set; }
        public Publisher publisher { get; set; }
        public Link link { get; set; }
        public List<Image> images { get; set; }
        public Flags flags { get; set; }
        public string version { get; set; }
        public string long_url { get; set; }
        public Keyimage keyimage { get; set; }
        public string version_id { get; set; }
        public string description { get; set; }
        public int license { get; set; }
        public string title_file { get; set; }
        public string title_english { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public Price price { get; set; }
        public string publishnotes { get; set; }
        public string short_url { get; set; }
    }

    public class RootObject
    {
        public Content content { get; set; }
    }
}

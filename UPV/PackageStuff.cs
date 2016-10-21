using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using UPV.AssetItems;
using System.Text.RegularExpressions;

namespace UPV
{
    internal static class PackageStuff
    {
        private static string str0 = "";

        private static string str1 = "";

        public static string Header
        {
            get
            {
                return str0;
            }

            set
            {
                str0 = value;
            }
        }

        public static bool IsValidAssetStorePackage(string FilePath)
        {
            bool blnRes = false;
            try
            {
                string strParsedJson = ParseHex(FilePath);
                if (strParsedJson.Contains("version")) blnRes = true;
            }
            catch { }

            return blnRes;
        }

        public static RootObject GetPackageDetails(String FilePath)
        {
            string strParsedJson = ParseHex(FilePath);
            //textBox1.Text = strParsedJson;
            RootObject itemData = null;
            try
            {
                itemData = JsonConvert.DeserializeObject<RootObject>(strParsedJson);
            }
            catch { }
            //iItemId = IntCevir(itemData.id);
            return itemData;
        }

        private static string ParseHex(string FilePath)
        {
            return ReadHeader(FilePath);
        }

        private static string CleanUp(String Text)
        {
            int iC = Text.Count(f => f == '{');

            var result = Text.Select((c, i) => new { Char = c, Index = i })
                  .Where(item => item.Char == '}')
                  .Skip(iC - 1)
                  .FirstOrDefault();

            int iI = result.Index;
            return (Text.Substring(0, iI + 1));
        }

        public static int IndexOfNth(this string input, string value, int startIndex, int nth)
        {
            if (nth < 1)
                throw new NotSupportedException("Param 'nth' must be greater than 0!");
            if (nth == 1)
                input.IndexOf(value, startIndex);
            return
                input.IndexOfNth(value, input.IndexOf(value, startIndex) + 1, --nth);
        }

        private static string ReadHeader(string fileName)
        {
            String strHeaders = "";
            try
            {
                
                using (StreamReader streamReader = new StreamReader(File.OpenRead(fileName)))
                {
                     str0 = streamReader.ReadLine();
                    str1 = Regex.Match(str0, "{[^^]*}}").ToString();

                    if (str1 == "")
                    {
                        char[] buffer = new char[2048];
                        streamReader.ReadBlock(buffer, 0, 2047);
                        string x = new string(buffer);
                        str1 = Regex.Match(x, "{[^^]*}}").ToString();
                    }

                }

                strHeaders = str1;
            }

            catch { }

            return strHeaders;
        }

     
    }
}

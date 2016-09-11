using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FileAccess
    {
        public string URL { get; set; }

        public List<string[]> ReadAllFile()
        {
            List<string[]> result = new List<string[]>();
            string[] Lines = File.ReadAllLines(URL);
            foreach (string s in Lines)
            {
                string[] props = s.Split('|');
                result.Add(props);
            }
            return result;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Export
    {
        public ExportedPost[] Posts { get; private set; }
        public String BasePath { get; private set; }

        private Export()
        {

        }

        public static Export Load(string path)
        {
            var export = new Export()
            {
                Posts = JsonConvert.DeserializeObject<ExportedPost[]>(File.ReadAllText(Path.Combine(path, "index.json"))),
                BasePath = path
            };
            return export;
        }
    }
}

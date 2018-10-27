using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ExportedPost
    {
        public String Id { get; set; }
        public DateTime Date { get; set; }

        public String OriginalUrl { get; set; }

        public String RebloggedFrom { get; set; }

        public String Caption { get; set; }

        public IEnumerable<String> Tags { get; set; }

        public List<ExportedMediaItem> Photos { get; set; }

        public ExportedPost()
        {
            Photos = new List<ExportedMediaItem>();
            Tags = Enumerable.Empty<String>();
        }
    }
}

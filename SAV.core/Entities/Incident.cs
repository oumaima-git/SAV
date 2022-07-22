using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.core.Entities
{
    public class Incident
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime date { get; set; }
        public int heure { get; set; }
        public string notes { get; set; }
        public string nature { get; set; }


    }
}

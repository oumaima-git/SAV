using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.core.Entities
{
    public class FamilleTiers
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Boolean Inactif { get; set; }
        public int Code { get; set; }
        public string Intitule { get; set; }
        public string Type { get; set; }

    }
}

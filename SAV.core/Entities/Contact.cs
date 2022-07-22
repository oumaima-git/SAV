using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.core.Entities
{
    public class Contact

    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string Email { get; set; }
        public int Cin { get; set; }
    }
}

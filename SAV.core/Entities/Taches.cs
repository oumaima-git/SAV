using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.core.Entities
{
    public class Taches
    {
        public int Id { get; set; }
        public string Intitule { get; set; }
        public DateTime DateCreation { get; set; }
        public string Type { get; set; }
        public DateTime DateDemarrage { get; set; }
        public string Observation { get; set; }
        public int Classement { get; set; }
        public Boolean Etat { get; set; }
        public string DescriptionTaches { get; set; }
        //public Echeance 
        //public Priorité
        public float Avancement { get; set; }


    }
}

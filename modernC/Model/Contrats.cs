using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modernC.Model
{
    public class Contrats
    {
        public int ID_CONTRAT { get; set; }
        public DateTime DATE_DEPART { get; set; }
        public DateTime DATE_RETOUR { get; set; }
        public float KM_DEPART { get; set; }
        public float KM_RETOUR { get; set; }
    }
}

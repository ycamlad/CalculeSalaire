using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeSalaire
{
    class maPaie
    {
        public maPaie(int heure, double taux)
        {
            this.heure = heure;
            this.taux = taux;
            brut = Math.Round(heure * taux * 52, 2);
            fed = Math.Round(Calcul.impotFed(brut), 2);
            prov = Math.Round(Calcul.impotProv(brut), 2);
            ae = Math.Round(Calcul.assurance(brut), 2);
            rrc = Math.Round(Calcul.RRC(brut), 2);
            total = Math.Round(fed + prov + ae + rrc, 2);
            net = Math.Round(brut - total, 2);
        }

        public int heure { get; set; }
        public double taux { get; set; }
        public double brut { get; set; }
        public double net { get; set; }
        public double total { get; set; }
        public double fed { get; set; }
        public double prov { get; set; }
        public double rrc { get; set; }
        public double ae { get; set; }

    }
}

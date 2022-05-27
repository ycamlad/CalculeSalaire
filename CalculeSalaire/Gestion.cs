using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeSalaire
{
    class Gestion
    {
        public List<Departement> depart { get; set; }

        public Gestion()
        {
            depart = new List<Departement>
            {
                new Departement { description = "Restaurants", taux = 19 },
                new Departement { description = "Maintenance", taux = 30 },
                new Departement { description = "Paysagiste", taux = 32 },
                new Departement { description = "Vente", taux = 28 }
            };
        }
    }
}

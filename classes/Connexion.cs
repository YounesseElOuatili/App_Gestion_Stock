using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.classes
{
    internal class Connexion
    {
        public bool ConnexValide(Gestion_StockEntities1 db, string Nom_ad, string mdp)
        {
            Admin U = new Admin();
            U.Nom_ad = Nom_ad;
            U.Mdp = mdp;
            var util = db.Admin.FirstOrDefault(s => s.Nom_ad == Nom_ad && s.Mdp == mdp);

            if (util != null)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}

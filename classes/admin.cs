using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.classes
{
    internal class admin
    {
        private Gestion_StockEntities1 db = new Gestion_StockEntities1();
        private Admin admi;

        //ajouter Admin
        public bool Ajouter_Ad(String Nom, String mdp)
        {
            admi = new Admin();
            admi.Nom_ad = Nom;
            admi.Mdp = mdp;


            if (db.Admin.SingleOrDefault(s => s.Nom_ad == Nom) == null)
            {
                db.Admin.Add(admi);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Modifier Admin
        public void ModifierAd(int id, String Nom, String mdp)
        {
            admi = new Admin();
            admi = db.Admin.SingleOrDefault(s => s.Id_ad == id);
            if (admi != null)
            {
                admi.Nom_ad = Nom;
                admi.Mdp = mdp;

                db.SaveChanges();
            }
        }

        //Supprimer Admin
        public void SupprimerAd(int id)
        {
            admi = new Admin();
            admi = db.Admin.SingleOrDefault(s => s.Id_ad == id);
            if (admi != null)
            {
                db.Admin.Remove(admi);
                db.SaveChanges();
            }

        }
    }
}

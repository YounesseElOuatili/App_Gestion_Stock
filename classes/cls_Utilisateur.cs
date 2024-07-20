using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.classes
{
    internal class cls_Utilisateur
    {
        private Gestion_StockEntities1 db = new Gestion_StockEntities1();
        private Utilisateur Util;

        //ajouter utilisateur
        public bool Ajouter_Util(String Nom, String Email)
        {
            Util = new Utilisateur();
            Util.Nom_util = Nom;
            Util.Email_util = Email;
           

            if(db.Utilisateur.SingleOrDefault(s=>s.Nom_util == Nom)== null)
            {
                db.Utilisateur.Add(Util);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }

        //Modifier Utilisateur
        public void ModifierUtil(int id,String Nom, String Email)
        {
            Util = new Utilisateur();
            Util = db.Utilisateur.SingleOrDefault(s => s.Id_util == id );
            if(Util != null)
            {
                Util.Nom_util = Nom;
                Util.Email_util = Email;
               
                db.SaveChanges();
            }
        }

        //Supprimer Utilisateur
        public void SupprimerUtil (int id)
        {
            Util = new Utilisateur();
            Util = db.Utilisateur.SingleOrDefault(s => s.Id_util == id);
            if (Util != null)
            {
                // Vérifiez si le site est référencé par des produits
                bool isReferenced = db.Produit.Any(p => p.Id_util == id);
                if (isReferenced)
                {
                    MessageBox.Show("Impossible de supprimer l'utilisateur car il est référencé par des produits.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.Utilisateur.Remove(Util);
                    db.SaveChanges();
                    MessageBox.Show("Utilisateur supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("L'utilisateur n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

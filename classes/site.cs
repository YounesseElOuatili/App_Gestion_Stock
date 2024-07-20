using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.classes
{
    internal class site
    {
        private Gestion_StockEntities1 db = new Gestion_StockEntities1();
        private Sites sit;

        public bool Ajouter_Site(string Nom_site, string Adresse)
        {
            sit = new Sites();
            sit.Nom_site = Nom_site;
            sit.Adresse = Adresse;
            

            if (db.Sites.SingleOrDefault(s => s.Nom_site == Nom_site) == null)
            {
                db.Sites.Add(sit);
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
        //Modifier Site
        public void ModifierSit(int id, string Nom,string Adresse)
        {
            sit = new Sites();
            sit = db.Sites.SingleOrDefault(s => s.Id_site == id);
            if (sit != null)
            {
                sit.Nom_site = Nom;
                sit.Adresse = Adresse;

                db.SaveChanges();
            }
        }

        //Supprimer Site
        public void SupprimerSit(int id)
        {
            sit = db.Sites.SingleOrDefault(s => s.Id_site == id);
            if (sit != null)
            {
                // Vérifiez si le site est référencé par des produits
                bool isReferenced = db.Produit.Any(p => p.Id_Site == id);
                if (isReferenced)
                {
                    MessageBox.Show("Impossible de supprimer le site car il est référencé par des produits.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.Sites.Remove(sit);
                    db.SaveChanges();
                    MessageBox.Show("Site supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Le site n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        }
    }

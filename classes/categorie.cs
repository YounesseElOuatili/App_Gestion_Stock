using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace GestionStock.classes
{
    internal class categorie
    {
        private Gestion_StockEntities1 db = new Gestion_StockEntities1();
        private Categorie cat;

        public bool Ajouter_Cat(String Nom_cat)
        {
            cat = new Categorie();
            cat.Nom_cat = Nom_cat;



            if (db.Categorie.SingleOrDefault(s => s.Nom_cat == Nom_cat) == null)
            {
                db.Categorie.Add(cat);
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
        //Modifier Categorie
        public void ModifierCat(int id, String Nom)
        {
            cat = new Categorie();
            cat = db.Categorie.SingleOrDefault(s => s.Id_cat == id);
            if (cat != null)
            {
                cat.Nom_cat = Nom;

                db.SaveChanges();
            }
        }

        //Supprimer Categorie
        public void SupprimerCat(int id)
        {
            cat = new Categorie();
            cat = db.Categorie.SingleOrDefault(s => s.Id_cat == id);
            if (cat != null)
            {
                bool isReferenced = db.Produit.Any(p => p.Id_cat == id);
                if (isReferenced)
                {
                    MessageBox.Show("Impossible de supprimer la catégorie car elle est référencée par des produits.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.Categorie.Remove(cat);
                    db.SaveChanges();
                    MessageBox.Show("La catégorie supprimée avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La catégorie n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

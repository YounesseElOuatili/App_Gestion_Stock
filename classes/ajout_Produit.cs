using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.classes
{
    internal class ajout_Produit
    {
        private Gestion_StockEntities1 db = new Gestion_StockEntities1();
        private Produit prod;


        //ajouter Produit
        public bool Ajouter_prod(string Marque, string Nom_prod, string Adresse_Mac, int Id_util, int Id_site,   int Id_cat )
        {
            prod = new Produit();
            prod.Marque = Marque;
            prod.Nom_prod = Nom_prod;
            prod.Adresse_Mac = Adresse_Mac;
            prod.Id_util = Id_util;
            prod.Id_Site= Id_site;
            prod.Id_cat = Id_cat;
           

            if (db.Produit.SingleOrDefault(s => s.Adresse_Mac == Adresse_Mac) == null)
            {
                db.Produit.Add(prod);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Modifier Produit
        public void ModifierProd(int id, string Marque, string Nom_prod, string Adresse_Mac, int Id_util, int Id_site, int Id_cat)
        {
            prod = new Produit();
            prod = db.Produit.SingleOrDefault(s => s.Id_prod == id);
            if (prod != null)
            {
                prod.Marque = Marque;
                prod.Nom_prod = Nom_prod;
                prod.Adresse_Mac = Adresse_Mac;
                prod.Id_util = Id_util;
                prod.Id_Site = Id_site;
                prod.Id_cat = Id_cat;
                db.SaveChanges();
            }
        }
        //Supprimer Utilisateur
        public void SupprimerProd(int id)
        {
            prod = new Produit();
            prod = db.Produit.SingleOrDefault(s => s.Id_prod == id);
            if (prod != null)
            {
                db.Produit.Remove(prod);
                db.SaveChanges();
            }

        }
    }
}

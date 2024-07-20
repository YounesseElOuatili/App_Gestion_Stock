using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class Liste_Cat : UserControl
    {
        private Gestion_StockEntities1 db;
        private static Liste_Cat Liste;

        public static Liste_Cat Instance
        {
            get
            {
                if (Liste == null)
                {
                    Liste = new Liste_Cat();
                }
                return Liste;
            }
        }
        public Liste_Cat()
        {
            InitializeComponent();
            db = new Gestion_StockEntities1();
            txtRech.Enabled = false;
        }
        //Afficher les catégories
        public void AfficherCat()
        {
            db = new Gestion_StockEntities1();
            dataCat.Rows.Clear();
            foreach (var S in db.Categorie)
            {
                dataCat.Rows.Add(false, S.Id_cat, S.Nom_cat);
            }
        }

        //vérifier combien de ligne est selectionnées
        public string VerifierSelect()
        {
            int nbrSelect = 0;
            for (int i = 0; i < dataCat.Rows.Count; i++)
            {
                if ((bool)dataCat.Rows[i].Cells[0].Value == true) //si la ligne est séléctionnée
                {
                    nbrSelect++;
                }
            }
            if (nbrSelect == 0)
            {
                return "Séléctionné une Catégorie";
            }
            if (nbrSelect > 1)
            {
                return "Séléctionné une seule Catégorie";
            }
            return null;
        }

        private void txtRech_Enter(object sender, EventArgs e)
        {
            if (txtRech.Text == "Recherche")
            {
                txtRech.Text = "";
                txtRech.ForeColor = Color.Black;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            formulaires.Categorie cat = new formulaires.Categorie(this);
            cat.ShowDialog();
        }

        private void Liste_Cat_Load(object sender, EventArgs e)
        {
            AfficherCat();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            formulaires.Categorie cat = new formulaires.Categorie(this);
            if (VerifierSelect() == null)
            {
                for (int i = 0; i < dataCat.Rows.Count; i++)
                {
                    if ((bool)dataCat.Rows[i].Cells[0].Value == true) //si le checkbox est vrai afficher les infos du catégorie
                    {
                        cat.IdSelect = (int)dataCat.Rows[i].Cells[1].Value;
                        cat.txtNomSite.Text = dataCat.Rows[i].Cells[2].Value.ToString();


                    }
                }
                cat.label2.Text = "Modifier Une Catégorie";
                cat.btnAjouterCat.Text = "Modifier";
                cat.txtNomSite.ForeColor = Color.White;
                cat.ShowDialog();
            }
            else
            {
                MessageBox.Show(VerifierSelect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            classes.categorie categorie = new classes.categorie();
            int idSelect = 0;
            for (int i = 0; i < dataCat.Rows.Count; i++)
            {
                if ((bool)dataCat.Rows[i].Cells[0].Value == true)
                {
                    idSelect++;
                }
            }
            if (idSelect == 0)
            {
                MessageBox.Show("Aucune Catégorie selectionner", "Suppression,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataCat.Rows.Count; i++)
                    {
                        if ((bool)dataCat.Rows[i].Cells[0].Value == true)
                        {
                            categorie.SupprimerCat(int.Parse(dataCat.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    AfficherCat();
                   
                }
                else
                {
                    MessageBox.Show("Supression annulée !", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void combRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRech.Enabled = true;
            txtRech.Text = "";
        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {
            db = new Gestion_StockEntities1();
            var listeRech = db.Categorie.ToList();
            if (txtRech.Text != "")
            {
                switch (combRech.Text)
                {
                    case "Nom":
                        listeRech = listeRech.Where(s => s.Nom_cat.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                }
            }
            dataCat.Rows.Clear();
            foreach (var l in listeRech)
            {
                dataCat.Rows.Add(false, l.Id_cat, l.Nom_cat);
            }
        }
    }
}

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
    public partial class Liste_Sites : UserControl
    {
        private Gestion_StockEntities1 db;
        private static Liste_Sites Liste;

        public static Liste_Sites Instance
        {
            get
            {
                if (Liste == null)
                {
                    Liste = new Liste_Sites();
                }
                return Liste;
            }
        }
        public Liste_Sites()
        {
            InitializeComponent();
            db = new Gestion_StockEntities1();
            txtRech.Enabled = false;
        }
        //Afficher les Sites
        public void AfficherSites()
        {
            db = new Gestion_StockEntities1();
            dataSites.Rows.Clear();
            foreach (var S in db.Sites)
            {
                dataSites.Rows.Add(false, S.Id_site, S.Nom_site, S.Adresse);
            }
        }
        //vérifier combien de ligne est selectionnées
        public string VerifierSelect()
        {
            int nbrSelect = 0;
            for (int i = 0; i < dataSites.Rows.Count; i++)
            {
                if ((bool)dataSites.Rows[i].Cells[0].Value == true) //si la ligne est séléctionnée
                {
                    nbrSelect++;
                }
            }
            if (nbrSelect == 0)
            {
                return "Séléctionné un Site";
            }
            if (nbrSelect > 1)
            {
                return "Séléctionné un seul Site";
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
            formulaires.Sites sites = new formulaires.Sites(this);
            sites.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            formulaires.Sites sites = new formulaires.Sites(this);
            if (VerifierSelect() == null)
            {
                for (int i = 0; i < dataSites.Rows.Count; i++)
                {
                    if ((bool)dataSites.Rows[i].Cells[0].Value == true) //si le checkbox est vrai afficher les infos d'utilisateur
                    {
                        sites.IdSelect = (int)dataSites.Rows[i].Cells[1].Value;
                        sites.txtNomSite.Text = dataSites.Rows[i].Cells[2].Value.ToString();
                        sites.txtAdresse.Text = dataSites.Rows[i].Cells[3].Value.ToString();


                    }
                }
                sites.label.Text = "Modifier Un Site";
                sites.btnAjouterSite.Text = "Modifier";
                sites.txtNomSite.ForeColor = Color.White;
                sites.txtAdresse.ForeColor = Color.White;
                sites.ShowDialog();
            }
            else
            {
                MessageBox.Show(VerifierSelect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            classes.site sit = new classes.site();
            int idSelect = 0;
            for (int i = 0; i < dataSites.Rows.Count; i++)
            {
                if ((bool)dataSites.Rows[i].Cells[0].Value == true)
                {
                    idSelect++;
                }
            }
            if (idSelect == 0)
            {
                MessageBox.Show("Aucun Site selectionner", "Suppression,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataSites.Rows.Count; i++)
                    {
                        if ((bool)dataSites.Rows[i].Cells[0].Value == true)
                        {
                            sit.SupprimerSit(int.Parse(dataSites.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    AfficherSites();
                   
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
            var listeRech = db.Sites.ToList();
            if (txtRech.Text != "")
            {
                switch (combRech.Text)
                {
                    case "Nom":
                        listeRech = listeRech.Where(s => s.Nom_site.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                   
                }
            }
            dataSites.Rows.Clear();
            foreach (var l in listeRech)
            {
                dataSites.Rows.Add(false, l.Id_site, l.Nom_site);
            }
        }

        private void Liste_Sites_Load_1(object sender, EventArgs e)
        {
            AfficherSites();
        }

        private void dataSites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

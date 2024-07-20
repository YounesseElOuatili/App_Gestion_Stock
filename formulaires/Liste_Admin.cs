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
    public partial class Liste_Admin : UserControl
    {
        private static Liste_Admin listAdmin;
        private Gestion_StockEntities1 db;
        public static Liste_Admin Instance
        {
            get
            {
                if (listAdmin == null)
                {
                    listAdmin = new Liste_Admin();
                }
                return listAdmin;
            }
        }


        public Liste_Admin()
        {
            InitializeComponent();
        }

        // Affichage des admins
        public void AfficherAdmin()
        {
            db = new Gestion_StockEntities1();
            dataAdmin.Rows.Clear();
            foreach (var S in db.Admin)
            {
                dataAdmin.Rows.Add(false, S.Id_ad, S.Nom_ad);
            }
        }
        //vérifier combien de ligne est selectionnées
        public string VerifierSelect()
        {
            int nbrSelect = 0;
            for (int i = 0; i < dataAdmin.Rows.Count; i++)
            {
                if ((bool)dataAdmin.Rows[i].Cells[0].Value == true) //si la ligne est séléctionnée
                {
                    nbrSelect++;
                }
            }
            if (nbrSelect == 0)
            {
                return "Séléctionné un Admin";
            }
            if (nbrSelect > 1)
            {
                return "Séléctionné un seul Admin";
            }
            return null;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            formulaires.AjoutAdmin ajoutAd = new formulaires.AjoutAdmin(this);
            ajoutAd.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {
            db = new Gestion_StockEntities1();
            var listeRech = db.Admin.ToList();
            if (txtRech.Text != "")
            {
                switch (combRech.Text)
                {
                    case "Nom":
                        listeRech = listeRech.Where(s => s.Nom_ad.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            dataAdmin.Rows.Clear();
            foreach (var l in listeRech)
            {
                dataAdmin.Rows.Add(false, l.Id_ad, l.Nom_ad);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            classes.admin ad = new classes.admin();
            int idSelect = 0;
            for (int i = 0; i < dataAdmin.Rows.Count; i++)
            {
                if ((bool)dataAdmin.Rows[i].Cells[0].Value == true)
                {
                    idSelect++;
                }
            }
            if (idSelect == 0)
            {
                MessageBox.Show("Aucun Admin selectionner", "Suppression,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataAdmin.Rows.Count; i++)
                    {
                        if ((bool)dataAdmin.Rows[i].Cells[0].Value == true)
                        {
                            ad.SupprimerAd(int.Parse(dataAdmin.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    AfficherAdmin();
                    MessageBox.Show("Supression avec succés", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression annulée !", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            formulaires.AjoutAdmin ajouter = new formulaires.AjoutAdmin(this);
            if (VerifierSelect() == null)
            {
                for (int i = 0; i < dataAdmin.Rows.Count; i++)
                {
                    if ((bool)dataAdmin.Rows[i].Cells[0].Value == true) //si le checkbox est vrai afficher les infos d'utilisateur
                    {
                        ajouter.IdSelect = (int)dataAdmin.Rows[i].Cells[1].Value;
                        ajouter.txtNomAd.Text = dataAdmin.Rows[i].Cells[2].Value.ToString();
                        

                    }
                }
                ajouter.labelAd.Text = "Modifier Un Admin";
                ajouter.btnAjouter.Text = "Modifier";
                ajouter.txtNomAd.ForeColor = Color.White;
                
                ajouter.ShowDialog();
            }
            else
            {
                MessageBox.Show(VerifierSelect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRech.Enabled = true;
            txtRech.Text = "";
        }

        private void combRech_Enter(object sender, EventArgs e)
        {
            if (txtRech.Text == "Recherche")
            {
                txtRech.Text = "";
                txtRech.ForeColor = Color.Black;
            }
        }

        private void txtRech_Leave(object sender, EventArgs e)
        {

        }

        private void Liste_Admin_Load(object sender, EventArgs e)
        {
            AfficherAdmin();
        }
    }
}

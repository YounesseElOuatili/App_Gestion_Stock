using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class AjoutProd : Form
    {
        private Gestion_StockEntities1 db;
        private UserControl userProd;
        public AjoutProd(UserControl userProd)
        {
            InitializeComponent();
            db = new Gestion_StockEntities1();
            this.userProd = userProd;

            //affichage des utilisateurs dans combobox
            comboUtil.DataSource = db.Utilisateur.ToList();
            comboUtil.DisplayMember = "Nom_util";
            comboUtil.ValueMember = "Id_util";

            //affichage des sites dans combobox
            comboSite.DataSource = db.Sites.ToList();
            comboSite.DisplayMember = "Nom_site";
            comboSite.ValueMember = "Id_site";

            //affichage des catégories dans combobox
            comboCat.DataSource = db.Categorie.ToList();
            comboCat.DisplayMember = "Nom_cat";
            comboCat.ValueMember = "Id_cat";
        }
        string champObli()
        {
            if (txtNomMarque.Text == "" || txtNomMarque.Text == "Marque")
            {
                return "Saisir la marque de produit";
            }
            if (txtNomPro.Text == "" || txtNomPro.Text == "Nom de Produit")
            {
                return "Saisir le nom de produit";
            }
            if (comboSite.SelectedItem == null)
            {
                return "Saisir l'Emplacement de produit";
            }
            if (comboUtil.SelectedItem == null)
            {
                return "Choisir l'utilisateur de produit";
            }
            if (comboCat.SelectedItem == null)
            {
                return "Choisir la catégorie de produit";
            }
            if (txtAdr.Text == "" || txtAdr.Text == "Adresse Mac")
            {
                return "Saisir l'Adresse Mac de produit";
            }

            return null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutProd_Load(object sender, EventArgs e)
        {

        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomMarque_Enter(object sender, EventArgs e)
        {
            if (txtNomMarque.Text == "Marque")
            {
                txtNomMarque.Text = "";
                txtNomMarque.ForeColor = Color.White;
            }
        }

        private void txtNomMarque_Leave(object sender, EventArgs e)
        {
            if (txtNomMarque.Text == "")
            {
                txtNomMarque.Text = "Marque";
                txtNomMarque.ForeColor = Color.Silver;
            }
        }
        private void txtNomPro_Enter(object sender, EventArgs e)
        {
            if (txtNomPro.Text == "Nom de Produit")
            {
                txtNomPro.Text = "";
                txtNomPro.ForeColor = Color.White;
            }
        }

        private void txtNomPro_Leave(object sender, EventArgs e)
        {
            if (txtNomPro.Text == "")
            {
                txtNomPro.Text = "Nom de Produit";
                txtNomPro.ForeColor = Color.Silver;
            }
        }

        private void txtQte_Enter(object sender, EventArgs e)
        {
            if (txtAdr.Text == "Id_Produit")
            {
                txtAdr.Text = "";
                txtAdr.ForeColor = Color.White;
            }
        }

        private void txtQte_Leave(object sender, EventArgs e)
        {
            if (txtAdr.Text == "")
            {
                txtAdr.Text = "Id_Produit";
                txtAdr.ForeColor = Color.Silver;
            }
        }

        public int IdSelect;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (champObli() != null)
            {
                MessageBox.Show(champObli(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (labelPro.Text == "Ajouter Un Produit")
                {
                    classes.ajout_Produit clsU = new classes.ajout_Produit();
                    if (clsU.Ajouter_prod(txtNomMarque.Text, txtNomPro.Text, txtAdr.Text,  Convert.ToInt32(comboUtil.SelectedValue), Convert.ToInt32(comboSite.SelectedValue), Convert.ToInt32(comboCat.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit Ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProd as Liste_prod).AfficherProd();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Produit déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //la modification
                {
                    classes.ajout_Produit clsU = new classes.ajout_Produit();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment affecter ces modifications?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsU.ModifierProd(IdSelect,txtNomMarque.Text, txtNomPro.Text, txtAdr.Text, Convert.ToInt32(comboUtil.SelectedValue), Convert.ToInt32(comboSite.SelectedValue), Convert.ToInt32(comboCat.SelectedValue));
                        //actualiser datagried
                        (userProd as Liste_prod).AfficherProd();
                        MessageBox.Show("Produit Modifer avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Modifications annulés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();

                    }
                }
            }
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboUtil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

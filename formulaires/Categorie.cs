using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class Categorie : Form
    {
        private UserControl utilis;
        public Categorie(UserControl utilis)
        {
            InitializeComponent();
            this.utilis = utilis;
        }
        //champs obligatoires 
        string champObli()
        {
            if (txtNomSite.Text == "" || txtNomSite.Text == "Nom du catégorie")
            {
                return "Saisir le nom du catégorie";
            }
            return null;
        }

        private void txtNomSite_Enter(object sender, EventArgs e)
        {
            if (txtNomSite.Text == "Nom du catégorie")
            {
                txtNomSite.Text = "";
                txtNomSite.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNomSite_Leave(object sender, EventArgs e)
        {
            if (txtNomSite.Text == "")
            {
                txtNomSite.Text = "Nom du catégorie";
                txtNomSite.ForeColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int IdSelect;

        private void btnAjouterCat_Click(object sender, EventArgs e)
        {
            if (champObli() != null)
            {
                MessageBox.Show(champObli(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (label2.Text == "Ajouter une Catégorie")
                {
                    classes.categorie clsU = new classes.categorie();
                    if (clsU.Ajouter_Cat(txtNomSite.Text) == true)
                    {
                        MessageBox.Show("Catégorie Ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (utilis as Liste_Cat).AfficherCat();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Catégorie déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //la modification
                {
                    classes.categorie clsU = new classes.categorie();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment affecter ces modifications?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsU.ModifierCat(IdSelect, txtNomSite.Text);
                        //actualiser datagried
                        (utilis as Liste_Cat).AfficherCat();
                        MessageBox.Show("Utilisateur Modifer avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    }
}

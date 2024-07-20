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
    public partial class Sites : Form
    {
        private UserControl utilis;
        public Sites(UserControl utilis)
        {
            InitializeComponent();
            this.utilis = utilis;
        }

        //champs obligatoires 
        string champObli()
        {
            if (txtNomSite.Text == "" || txtNomSite.Text == "Nom de site")
            {
                return "Saisir le nom de Site";
            }
            if(txtAdresse.Text == "" ||txtAdresse.Text == "Adresse")
            {
                return "Saisir l'adresse";
            }
            return null;
        }
            private void Sites_Load(object sender, EventArgs e)
        {

        }

        private void txtNomSite_Enter(object sender, EventArgs e)
        {
            if (txtNomSite.Text == "Nom de site")
            {
                txtNomSite.Text = "";
                txtNomSite.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNomSite_Leave(object sender, EventArgs e)
        {
            if (txtNomSite.Text == "")
            {
                txtNomSite.Text = "Nom de site";
                txtNomSite.ForeColor = Color.Gray;
            }
        }
        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse";
                txtAdresse.ForeColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int IdSelect;

        private void btnAjouterSite_Click(object sender, EventArgs e)
        {
            if (champObli() != null)
            {
                MessageBox.Show(champObli(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (label.Text == "Ajouter un Site")
                {
                    classes.site clsU = new classes.site();
                    if (clsU.Ajouter_Site(txtNomSite.Text, txtAdresse.Text) == true)
                    {
                        MessageBox.Show("Site Ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (utilis as Liste_Sites).AfficherSites();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Site déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //la modification
                {
                    classes.site clsU = new classes.site();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment affecter ces modifications?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsU.ModifierSit(IdSelect, txtNomSite.Text, txtAdresse.Text);
                        //actualiser datagried
                        (utilis as Liste_Sites).AfficherSites();
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

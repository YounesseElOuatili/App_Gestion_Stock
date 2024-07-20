using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class AjoutAdmin : Form
    {
        private UserControl utilis;
        public AjoutAdmin(UserControl utilis)
        {
            InitializeComponent();
            this.utilis = utilis;
        }
        string champObli()
        {
            if (txtNomAd.Text == "" || txtNomAd.Text == "Nom d'utilisateur")
            {
                return "Saisir le nom d'Admin";
            }
            if (txtMdp.Text == "" || txtMdp.Text == "Mot de Passe")
            {
                return "Saisir le mot de passe";
            }
            return null;
        }

        private void AjoutAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomAd_Enter(object sender, EventArgs e)
        {
            if (txtNomAd.Text == "Nom d'utilisateur")
            {
                txtNomAd.Text = "";
                txtNomAd.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtMdp_Enter(object sender, EventArgs e)
        {
            if (txtMdp.Text == "Mot de Passe")
            {
                txtMdp.Text = "";
                txtMdp.UseSystemPasswordChar = false;
                txtMdp.PasswordChar = '*';
                txtMdp.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNomAd_Leave(object sender, EventArgs e)
        {
            if (txtNomAd.Text == "")
            {
                txtNomAd.Text = "Nom d'utilisateur";
                txtNomAd.ForeColor = Color.Gray;
            }
        }

        private void txtMdp_Leave(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                txtMdp.Text = "Mot de Passe";
                txtMdp.UseSystemPasswordChar = true;
                txtMdp.ForeColor = Color.Gray;
            }
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            if (txtMdp.UseSystemPasswordChar == false)
            {
                txtMdp.UseSystemPasswordChar = true;
            }
            else
            {
                txtMdp.UseSystemPasswordChar = false;
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
                if (labelAd.Text == "Ajouter un Admin")
                {
                    classes.admin clsU = new classes.admin();
                    if (clsU.Ajouter_Ad(txtNomAd.Text, txtMdp.Text) == true)
                    {
                        MessageBox.Show("Admin Ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (utilis as Liste_Admin).AfficherAdmin();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Admin déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //la modification
                {
                    classes.admin clsU = new classes.admin();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment affecter ces modifications?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsU.ModifierAd(IdSelect, txtNomAd.Text, txtMdp.Text);
                        //actualiser datagried
                        MessageBox.Show("Admin Modifer avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (utilis as Liste_Admin).AfficherAdmin();
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

        private void txtNomAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

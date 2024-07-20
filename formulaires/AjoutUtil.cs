using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionStock.formulaires
{
    public partial class AjoutUtil : Form
    {
        private UserControl utilis;
        public AjoutUtil(UserControl utilis)
        {
            InitializeComponent();
            this.utilis = utilis;
        }

        //champs obligatoires 
        string champObli ()
        {
            if(txtNomUtil.Text == "" || txtNomUtil.Text == "Nom d'utilisateur")
            {
                return "Saisir le nom d'utilisateur";
            }
            if (txtEmail.Text == "" || txtEmail.Text == "Email")
            {
                return "Saisir l'Email";
            }
            
            //verifier email 
            if (txtEmail.Text != "" || txtEmail.Text != "Email")
            {
                try
                {
                    new MailAddress(txtEmail.Text);
                }catch (Exception e)
                {
                    return "Email Invalid";
                }
            }
            return null;
        }
        private void AjoutUtil_Load(object sender, EventArgs e)
        {

        }

        private void txtNomUtil_Enter(object sender, EventArgs e)
        {

            if (txtNomUtil.Text == "Nom d'utilisateur")
            {
                txtNomUtil.Text = "";
                txtNomUtil.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.WhiteSmoke;
            }
        }

       

        private void txtNomUtil_Leave(object sender, EventArgs e)
        {
            if (txtNomUtil.Text == "")
            {
                txtNomUtil.Text = "Nom d'utilisateur";
                txtNomUtil.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int IdSelect;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(champObli() != null)
            {
                MessageBox.Show(champObli(),"Obligatoire",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(label1.Text == "Ajouter Un Utilisateur")
                {
                    classes.cls_Utilisateur clsU = new classes.cls_Utilisateur();
                    if (clsU.Ajouter_Util(txtNomUtil.Text, txtEmail.Text) == true)
                    {
                        MessageBox.Show("Utilisateur Ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (utilis as Liste_util).AfficherUtil();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else //la modification
                {
                    classes.cls_Utilisateur clsU = new classes.cls_Utilisateur();
                    DialogResult R = MessageBox.Show("Voulez-vous vraiment affecter ces modifications?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        clsU.ModifierUtil(IdSelect, txtNomUtil.Text, txtEmail.Text);
                        //actualiser datagried
                        (utilis as Liste_util).AfficherUtil();
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

        private void txtNomUtil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

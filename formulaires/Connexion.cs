using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionStock.formulaires
{
    public partial class Connexion : Form
    {
        private Gestion_StockEntities1 db;
        private Form frmMenu;
        // classe connexion
        classes.Connexion con = new classes.Connexion();
        public Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmMenu = Menu;
            // intialiser BD
            db = new Gestion_StockEntities1();
        }
        String testChamp()
        {
            if(txtNom.Text == "" || txtNom.Text == "Nom d'utilisateur")
            {
                return "Entrer votre Nom";
            }
            if (txtMdp.Text == "" || txtMdp.Text == "Mot de passe")
            {
                return "Entrer votre mot de passe";
            }
            return null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            acc.Instance.BringToFront();
            this.Close();
            
            

        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtMdp_Enter(object sender, EventArgs e)
        {
            if (txtMdp.Text == "Mot de passe")
            {
                txtMdp.Text = "";
                txtMdp.UseSystemPasswordChar = false;
                txtMdp.PasswordChar = '*';
                txtMdp.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if(txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Gray;
            }
        }

        private void txtMdp_Leave(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                txtMdp.Text = "Mot de passe";
                txtMdp.UseSystemPasswordChar = true;
                txtMdp.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (txtMdp.UseSystemPasswordChar == false)
            {
                txtMdp.UseSystemPasswordChar = true;
            }else
            {
                txtMdp.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testChamp()== null)
            {
                if(con.ConnexValide(db, txtNom.Text, txtMdp.Text) == true)
                {
                    MessageBox.Show("Connexion a réussi","Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmMenu as Acceuil).activerForm();
                    this.Close();
           
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(testChamp(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Acceuil : Form
    {
       

        public Acceuil()
        {
            InitializeComponent();
            panel1.Size = new Size(90, 891);
            pnlM.Visible = false;

           
        }
        //desactiver forme
        public void desactiverForm()
        {
            btnAd.Enabled = false;
            btnUtil.Enabled = false;
            btnSite.Enabled = false;
            btnPro.Enabled = false;
            btnCat.Enabled = false;
            btnDec.Enabled = false;
            pnB.Enabled = false;
            btnCon.Enabled = true;
        }

        //activer form 
        public void activerForm()
        {
            btnAd.Enabled = true;
            btnUtil.Enabled = true;
            btnSite.Enabled = true;
            btnPro.Enabled = true;
            btnCat.Enabled = true;
            btnDec.Enabled = true;
            pnB.Enabled = true;
            btnCon.Enabled = false;
            pnlM.Visible=false;
            lab.Visible = true;
        }
        private void Acceuil_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlM.Size = new Size(243, 146);
            pnlM.Visible = !pnlM.Visible;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panel1.Width== 240)
            {
                panel1.Size = new Size(90, 891);
            }else
            {
                panel1.Size = new Size(240,  891);
            }
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            pnB.Top = btnPro.Top;
            if (!pnListe.Controls.Contains(Liste_prod.Instance))
            {
                pnListe.Controls.Add(Liste_prod.Instance);
                Liste_prod.Instance.Dock = DockStyle.Fill;
                Liste_prod.Instance.BringToFront();
            }
            else
            {
                Liste_prod.Instance.BringToFront();
            }

        }


        private void btnCat_Click(object sender, EventArgs e)
        {
            pnB.Top = btnCat.Top;
            
            if (!pnListe.Controls.Contains(Liste_Cat.Instance))
            {
                pnListe.Controls.Add(Liste_Cat.Instance);
                Liste_Cat.Instance.Dock = DockStyle.Fill;
                Liste_Cat.Instance.BringToFront();
            }
            else
            {
                Liste_Cat.Instance.BringToFront();
            }

        }

        private void btnUtil_Click(object sender, EventArgs e)
        {
            pnB.Top = btnUtil.Top;
            if (!pnListe.Controls.Contains(Liste_util.Instance))
            {
                pnListe.Controls.Add(Liste_util.Instance);
                Liste_util.Instance.Dock = DockStyle.Fill;
                Liste_util.Instance.BringToFront();
            }
            else
            {
                Liste_util.Instance.BringToFront();
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            lab.Visible = false;
            Connexion frmC = new Connexion(this);
            frmC.ShowDialog();
            pnlM.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            desactiverForm();
            if (!pnListe.Controls.Contains(acc.Instance))
            {
                pnListe.Controls.Add(acc.Instance);
                acc.Instance.Dock = DockStyle.Fill;
                acc.Instance.BringToFront();
                pnlM.Visible = false;
            }
            else
            {
                acc.Instance.BringToFront();
                pnlM.Visible = false;
            }

        }

        private void pnListe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            pnB.Top = btnAd.Top;
            if (!pnListe.Controls.Contains(Liste_Admin.Instance))
            {
                pnListe.Controls.Add(Liste_Admin.Instance);
                Liste_Admin.Instance.Dock = DockStyle.Fill;
                Liste_Admin.Instance.BringToFront();
            }
            else
            {
                Liste_Admin.Instance.BringToFront();
            }
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            pnB.Top = btnSite.Top;
            if (!pnListe.Controls.Contains(Liste_Sites.Instance))
            {
                pnListe.Controls.Add(Liste_Sites.Instance);
                Liste_Sites.Instance.Dock = DockStyle.Fill;
                Liste_Sites.Instance.BringToFront();
            }
            else
            {
                Liste_Sites.Instance.BringToFront();
            }
        }

        private void lab_Click(object sender, EventArgs e)
        {

        }
    }
}

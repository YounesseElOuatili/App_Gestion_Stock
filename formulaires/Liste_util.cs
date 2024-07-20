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
    public partial class Liste_util : UserControl
    {
        private static Liste_util Liste;
        private Gestion_StockEntities1 db;


        public static Liste_util Instance
        {
            get
            {
                if(Liste==null)
                {
                    Liste = new Liste_util();
                }
                return Liste;
            }
        }

        public Liste_util()
        {
            InitializeComponent();
            db = new Gestion_StockEntities1();
            txtRech.Enabled = false;
        }

        //Afficher les utilisateurs
        public void AfficherUtil()
        {
            db = new Gestion_StockEntities1();
            dataUtil.Rows.Clear();
            foreach(var S in db.Utilisateur)
            {
                dataUtil.Rows.Add(false,S.Id_util, S.Nom_util, S.Email_util);
            }
        }

        //vérifier combien de ligne est selectionnées
        public string VerifierSelect()
        {
            int nbrSelect = 0;
            for(int i = 0; i<dataUtil.Rows.Count; i++)
            {
                if ((bool)dataUtil.Rows[i].Cells[0].Value==true) //si la ligne est séléctionnée
                {
                    nbrSelect++;
                }
            }
            if(nbrSelect == 0)
            {
                return "Séléctionné un Utilisateur";
            }
            if (nbrSelect > 1)
            {
                return "Séléctionné un seul Utilisateur";
            }
            return null;
        }
        private void Liste_util_Load(object sender, EventArgs e)
        {
            AfficherUtil();
        }

        private void txtRech_Enter(object sender, EventArgs e)
        {
            if(txtRech.Text == "Recherche")
            {
                txtRech.Text = "";
                txtRech.ForeColor = Color.Black;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            formulaires.AjoutUtil ajoutUtil = new formulaires.AjoutUtil(this);
            ajoutUtil.ShowDialog();
        }

        

        private void btnModif_Click(object sender, EventArgs e)
        {
            formulaires.AjoutUtil ajouter = new formulaires.AjoutUtil(this);
            if (VerifierSelect() == null)
            {
                for(int i=0; i<dataUtil.Rows.Count; i++)
                {
                    if ((bool)dataUtil.Rows[i].Cells[0].Value == true) //si le checkbox est vrai afficher les infos d'utilisateur
                    {
                        ajouter.IdSelect = (int)dataUtil.Rows [i].Cells[1].Value;
                        ajouter.txtNomUtil.Text = dataUtil.Rows [i].Cells[2].Value.ToString();
                        ajouter.txtEmail.Text = dataUtil.Rows[i].Cells[3].Value.ToString();

                    }
                }
                ajouter.label1.Text = "Modifier Un Utilisateur";
                ajouter.btnAjouter.Text = "Modifier";
                ajouter.txtNomUtil.ForeColor = Color.White;
                ajouter.txtEmail.ForeColor = Color.White;
                ajouter.ShowDialog();
            }else
            {
                MessageBox.Show(VerifierSelect(),"Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            classes.cls_Utilisateur util = new classes.cls_Utilisateur();
            int idSelect = 0;
            for(int i=0; i<dataUtil.Rows.Count; i++)
            {
                if ((bool)dataUtil.Rows[i].Cells [0].Value == true)
                {
                    idSelect++;
                }
            }
            if(idSelect == 0)
            {
                MessageBox.Show("Aucun Utilisateur selectionner","Suppression,", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataUtil.Rows.Count; i++)
                    {
                        if ((bool)dataUtil.Rows[i].Cells[0].Value == true)
                        {
                            util.SupprimerUtil(int.Parse(dataUtil.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    AfficherUtil(); 
                    
                }else
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
            var listeRech = db.Utilisateur.ToList();
            if(txtRech.Text != "")
            {
                switch (combRech.Text)
                {
                    case "Nom":
                        listeRech = listeRech.Where(s => s.Nom_util.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        break;
                    case "Email":
                        listeRech = listeRech.Where(s => s.Email_util.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            dataUtil.Rows.Clear();
            foreach(var l in listeRech)
            {
                dataUtil.Rows.Add(false, l.Id_util, l.Nom_util, l.Email_util);
            }
        }

        private void dataUtil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRech_Leave(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

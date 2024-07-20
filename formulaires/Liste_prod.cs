using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.xmp.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace GestionStock.formulaires
{
    public partial class Liste_prod : UserControl
    {
        private static Liste_prod Liste;
        private Gestion_StockEntities1 db;

        public static Liste_prod Instance
        {
            get
            {
                if (Liste == null)
                {
                    Liste = new Liste_prod();
                }
                return Liste;
            }
        }
        public Liste_prod()
        {
            InitializeComponent();
            db = new Gestion_StockEntities1();
            txtRech.Enabled = false;
        }
        //Afficher les Produits
        public void AfficherProd()
        {
            db = new Gestion_StockEntities1();
           

            dataProd.Rows.Clear();
            foreach (var S in db.Produit)
            {
                var util = db.Utilisateur.SingleOrDefault(u => u.Id_util == S.Id_util);
                var cat = db.Categorie.SingleOrDefault(c => c.Id_cat == S.Id_cat);
                var site = db.Sites.SingleOrDefault(si => si.Id_site == S.Id_Site);

                string utilName = util != null ? util.Nom_util : "Unknown";
                string catName = cat != null ? cat.Nom_cat : "Unknown";
                string siteName = site != null ? site.Adresse: "Unknown";

                dataProd.Rows.Add(false,S.Id_prod, S.Marque, S.Nom_prod, S.Adresse_Mac, utilName, siteName, catName);
            }
        }

        //vérifier combien de ligne est selectionnées
        public string VerifierSelect()
        {
            int nbrSelect = 0;
            for (int i = 0; i < dataProd.Rows.Count; i++)
            {
                if ((bool)dataProd.Rows[i].Cells[0].Value == true) //si la ligne est séléctionnée
                {
                    nbrSelect++;
                }
            }
            if (nbrSelect == 0)
            {
                return "Séléctionné un Produit";
            }
            if (nbrSelect > 1)
            {
                return "Séléctionné un seul Produit";
            }
            return null;
        }

        private void Liste_prod_Load(object sender, EventArgs e)
        {
            AfficherProd();
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
            formulaires.AjoutProd ajoutProd = new formulaires.AjoutProd(this);
            ajoutProd.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            formulaires.AjoutProd ajouter = new formulaires.AjoutProd(this);
            if (VerifierSelect() == null)
            {
                for (int i = 0; i < dataProd.Rows.Count; i++)
                {
                    if ((bool)dataProd.Rows[i].Cells[0].Value == true) //si le checkbox est vrai afficher les infos dde produit
                    {
                        ajouter.IdSelect = (int)dataProd.Rows[i].Cells[1].Value;
                        ajouter.txtNomMarque.Text = dataProd.Rows[i].Cells[2].Value.ToString();
                        ajouter.txtNomPro.Text = dataProd.Rows[i].Cells[3].Value.ToString();
                        ajouter.txtAdr.Text = dataProd.Rows[i].Cells[4].Value.ToString();
                        ajouter.comboSite.Text = dataProd.Rows[i].Cells[5].Value.ToString();
                        ajouter.comboUtil.Text = dataProd.Rows[i].Cells[6].Value.ToString();
                        ajouter.comboCat.Text = dataProd.Rows[i].Cells[7].Value.ToString();


                    }
                }
                ajouter.labelPro.Text = "Modifier Un Produit";
                ajouter.btnAjouterPro.Text = "Modifier";
                ajouter.txtNomMarque.ForeColor = Color.White;
                ajouter.txtNomPro.ForeColor = Color.White;
                ajouter.txtAdr.ForeColor = Color.White;
                ajouter.ShowDialog();
            }
            else
            {
                MessageBox.Show(VerifierSelect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            classes.ajout_Produit prod = new classes.ajout_Produit();
            int idSelect = 0;
            for (int i = 0; i < dataProd.Rows.Count; i++)
            {
                if ((bool)dataProd.Rows[i].Cells[0].Value == true)
                {
                    idSelect++;
                }
            }
            if (idSelect == 0)
            {
                MessageBox.Show("Aucun Produit selectionner", "Suppression,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataProd.Rows.Count; i++)
                    {
                        if ((bool)dataProd.Rows[i].Cells[0].Value == true)
                        {
                            prod.SupprimerProd(int.Parse(dataProd.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    AfficherProd();
                    MessageBox.Show("Supression avec succés", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            var listeRech = db.Produit.ToList();
            
            if (txtRech.Text != "")
            {
                switch (combRech.Text)
                {
                    case "Marque":
                        listeRech = listeRech.Where(s => s.Marque.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Nom":
                        listeRech = listeRech.Where(s => s.Nom_prod.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse_Mac":
                        listeRech = listeRech.Where(s => s.Adresse_Mac.IndexOf(txtRech.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            dataProd.Rows.Clear();
            foreach (var S in listeRech)
            {
                var util = db.Utilisateur.SingleOrDefault(u => u.Id_util == S.Id_util);
                var cat = db.Categorie.SingleOrDefault(c => c.Id_cat == S.Id_cat);
                var site = db.Sites.SingleOrDefault(si => si.Id_site == S.Id_Site);

                string utilName = util != null ? util.Nom_util : "Unknown";
                string catName = cat != null ? cat.Nom_cat : "Unknown";
                string siteName = site != null ? site.Nom_site : "Unknown";
                dataProd.Rows.Add(false, S.Id_prod, S.Marque, S.Nom_prod, S.Adresse_Mac, utilName, siteName, catName);
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataProd.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Liste.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Impossible d'exporter les données : " + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataProd.Columns.Count - 2);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Add the header row
                            for (int i = 1; i < dataProd.Columns.Count; i++)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(dataProd.Columns[i].HeaderText));
                                pTable.AddCell(pCell);
                            }

                            // Add the data rows
                            foreach (DataGridViewRow viewRow in dataProd.Rows)
                            {
                                for (int i = 1; i < dataProd.Columns.Count; i++)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(viewRow.Cells[i].Value?.ToString()));
                                    pTable.AddCell(pCell);
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(iTextSharp.text.PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                                writer.PageEvent = new PdfPageEvents("Liste des Produits"); // Pass the title to the page event
                                document.Open();

                                // Create the title paragraph with alignment and spacing
                                Paragraph titleParagraph = new Paragraph("Liste des Produits", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
                                {
                                    Alignment = Element.ALIGN_CENTER,
                                    SpacingAfter = 20f  // Adding space after the title
                                };
                                document.Add(titleParagraph);

                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }

                            MessageBox.Show("Exportation de données réussie", "Exportation");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de l'exportation des données : " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun Data Trouvé", "Info");
            }
        }

        private void dataProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    // Custom page event handler for adding page numbers and title
    public class PdfPageEvents : PdfPageEventHelper
    {
        private string title;
        private PdfTemplate total;

        public PdfPageEvents(string title)
        {
            this.title = title;
        }

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            total = writer.DirectContent.CreateTemplate(50, 50);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable footer = new PdfPTable(3);
            footer.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            footer.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;  // Fully qualified to avoid conflict
            footer.AddCell(new PdfPCell(new Phrase(title)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
            footer.AddCell(new PdfPCell() { Border = iTextSharp.text.Rectangle.NO_BORDER });
            footer.AddCell(new PdfPCell(new Phrase("Page " + writer.PageNumber)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            footer.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 10, writer.DirectContent);
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            ColumnText.ShowTextAligned(total, Element.ALIGN_LEFT, new Phrase((writer.PageNumber - 1).ToString()), 2, 2, 0);
        }
    }

}


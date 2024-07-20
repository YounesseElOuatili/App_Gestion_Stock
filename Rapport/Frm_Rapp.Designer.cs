namespace GestionStock.Rapport
{
    partial class Frm_Rapp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RappAffich = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RappAffich
            // 
            this.RappAffich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RappAffich.LocalReport.ReportEmbeddedResource = "GestionStock.Rapport.Rapp_prod.rdlc";
            this.RappAffich.Location = new System.Drawing.Point(0, 0);
            this.RappAffich.Name = "RappAffich";
            this.RappAffich.ServerReport.BearerToken = null;
            this.RappAffich.Size = new System.Drawing.Size(874, 744);
            this.RappAffich.TabIndex = 0;
            this.RappAffich.Load += new System.EventHandler(this.RappAffich_Load);
            // 
            // Frm_Rapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 744);
            this.Controls.Add(this.RappAffich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Rapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.Frm_Rapp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RappAffich;
    }
}
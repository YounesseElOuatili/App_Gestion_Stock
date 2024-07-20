namespace GestionStock.formulaires
{
    partial class Liste_Cat
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataCat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combRech = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRech = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCat
            // 
            this.dataCat.AllowUserToAddRows = false;
            this.dataCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCat.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataCat.EnableHeadersVisualStyles = false;
            this.dataCat.Location = new System.Drawing.Point(14, 200);
            this.dataCat.Name = "dataCat";
            this.dataCat.RowHeadersVisible = false;
            this.dataCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCat.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataCat.Size = new System.Drawing.Size(1320, 805);
            this.dataCat.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // combRech
            // 
            this.combRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combRech.FormattingEnabled = true;
            this.combRech.Items.AddRange(new object[] {
            "Nom"});
            this.combRech.Location = new System.Drawing.Point(541, 140);
            this.combRech.Name = "combRech";
            this.combRech.Size = new System.Drawing.Size(277, 33);
            this.combRech.TabIndex = 27;
            this.combRech.SelectedIndexChanged += new System.EventHandler(this.combRech_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(857, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 25;
            // 
            // txtRech
            // 
            this.txtRech.BackColor = System.Drawing.SystemColors.Control;
            this.txtRech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRech.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRech.Location = new System.Drawing.Point(902, 133);
            this.txtRech.Multiline = true;
            this.txtRech.Name = "txtRech";
            this.txtRech.Size = new System.Drawing.Size(339, 40);
            this.txtRech.TabIndex = 24;
            this.txtRech.Text = "Recherche";
            this.txtRech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRech.TextChanged += new System.EventHandler(this.txtRech_TextChanged);
            this.txtRech.Enter += new System.EventHandler(this.txtRech_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(120, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 5);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(120, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 5);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionStock.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(858, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnSupp
            // 
            this.btnSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupp.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSupp.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnSupp.FlatAppearance.BorderSize = 0;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupp.Image = global::GestionStock.Properties.Resources.trash;
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupp.Location = new System.Drawing.Point(947, 34);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(326, 55);
            this.btnSupp.TabIndex = 19;
            this.btnSupp.Text = "   Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModif
            // 
            this.btnModif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModif.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnModif.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnModif.FlatAppearance.BorderSize = 0;
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModif.Image = global::GestionStock.Properties.Resources.edit;
            this.btnModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModif.Location = new System.Drawing.Point(534, 34);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(326, 55);
            this.btnModif.TabIndex = 20;
            this.btnModif.Text = "   Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAjout.FlatAppearance.BorderSize = 0;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjout.Image = global::GestionStock.Properties.Resources.category;
            this.btnAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjout.Location = new System.Drawing.Point(120, 34);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(326, 55);
            this.btnAjout.TabIndex = 21;
            this.btnAjout.Text = "   Ajouter ";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // Liste_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataCat);
            this.Controls.Add(this.combRech);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRech);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Name = "Liste_Cat";
            this.Size = new System.Drawing.Size(1348, 1038);
            this.Load += new System.EventHandler(this.Liste_Cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox combRech;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRech;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
    }
}

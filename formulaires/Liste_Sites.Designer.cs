﻿namespace GestionStock.formulaires
{
    partial class Liste_Sites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSites = new System.Windows.Forms.DataGridView();
            this.combRech = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRech = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSites
            // 
            this.dataSites.AllowUserToAddRows = false;
            this.dataSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSites.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataSites.EnableHeadersVisualStyles = false;
            this.dataSites.Location = new System.Drawing.Point(13, 195);
            this.dataSites.Name = "dataSites";
            this.dataSites.RowHeadersVisible = false;
            this.dataSites.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSites.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataSites.Size = new System.Drawing.Size(1320, 805);
            this.dataSites.TabIndex = 18;
            this.dataSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSites_CellContentClick);
            // 
            // combRech
            // 
            this.combRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combRech.FormattingEnabled = true;
            this.combRech.Items.AddRange(new object[] {
            "Nom"});
            this.combRech.Location = new System.Drawing.Point(540, 135);
            this.combRech.Name = "combRech";
            this.combRech.Size = new System.Drawing.Size(277, 33);
            this.combRech.TabIndex = 17;
            this.combRech.SelectedIndexChanged += new System.EventHandler(this.combRech_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(856, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 15;
            // 
            // txtRech
            // 
            this.txtRech.BackColor = System.Drawing.SystemColors.Control;
            this.txtRech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRech.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRech.Location = new System.Drawing.Point(901, 128);
            this.txtRech.Multiline = true;
            this.txtRech.Name = "txtRech";
            this.txtRech.Size = new System.Drawing.Size(339, 40);
            this.txtRech.TabIndex = 14;
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
            this.panel2.Location = new System.Drawing.Point(119, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(119, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 5);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionStock.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(857, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.TabIndex = 16;
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
            this.btnSupp.Location = new System.Drawing.Point(946, 29);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(326, 55);
            this.btnSupp.TabIndex = 9;
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
            this.btnModif.Location = new System.Drawing.Point(533, 29);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(326, 55);
            this.btnModif.TabIndex = 10;
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
            this.btnAjout.Image = global::GestionStock.Properties.Resources.add_pointer__1_;
            this.btnAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjout.Location = new System.Drawing.Point(119, 29);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(326, 55);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.Text = "   Ajouter ";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
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
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            // 
            // Liste_Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataSites);
            this.Controls.Add(this.combRech);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRech);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Name = "Liste_Sites";
            this.Size = new System.Drawing.Size(1348, 1038);
            this.Load += new System.EventHandler(this.Liste_Sites_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSites;
        private System.Windows.Forms.ComboBox combRech;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRech;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

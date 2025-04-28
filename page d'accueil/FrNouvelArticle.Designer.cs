namespace page_d_accueil
{
    partial class FrNouvelArticle
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
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblFabricant = new System.Windows.Forms.Label();
            this.cbFabricant = new System.Windows.Forms.ComboBox();
            this.lblUnite = new System.Windows.Forms.Label();
            this.cbUnite = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(12, 19);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(76, 16);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Référence :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(94, 16);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(139, 22);
            this.txtRef.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(263, 22);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(53, 16);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(322, 19);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(195, 22);
            this.txtLibelle.TabIndex = 3;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 65);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(72, 16);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(90, 62);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(143, 24);
            this.cbCategorie.TabIndex = 5;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(263, 65);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(69, 16);
            this.lblFabricant.TabIndex = 6;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(338, 62);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(179, 24);
            this.cbFabricant.TabIndex = 7;
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(40, 112);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(44, 16);
            this.lblUnite.TabIndex = 8;
            this.lblUnite.Text = "Unité :";
            // 
            // cbUnite
            // 
            this.cbUnite.FormattingEnabled = true;
            this.cbUnite.Location = new System.Drawing.Point(90, 104);
            this.cbUnite.Name = "cbUnite";
            this.cbUnite.Size = new System.Drawing.Size(51, 24);
            this.cbUnite.TabIndex = 9;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(123, 159);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(292, 159);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrNouvelArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 216);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbUnite);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.cbFabricant);
            this.Controls.Add(this.lblFabricant);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblRef);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrNouvelArticle";
            this.Text = "Ajouter un nouvel article";
            this.Load += new System.EventHandler(this.FrNouvelArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblFabricant;
        private System.Windows.Forms.ComboBox cbFabricant;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.ComboBox cbUnite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
    }
}
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
            this.lblRef.Location = new System.Drawing.Point(9, 15);
            this.lblRef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(63, 13);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Référence :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(70, 13);
            this.txtRef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(105, 20);
            this.txtRef.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(197, 18);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(242, 15);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(147, 20);
            this.txtLibelle.TabIndex = 3;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(9, 53);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(68, 50);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(108, 21);
            this.cbCategorie.TabIndex = 5;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(197, 53);
            this.lblFabricant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(57, 13);
            this.lblFabricant.TabIndex = 6;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(254, 50);
            this.cbFabricant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(135, 21);
            this.cbFabricant.TabIndex = 7;
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(30, 91);
            this.lblUnite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(38, 13);
            this.lblUnite.TabIndex = 8;
            this.lblUnite.Text = "Unité :";
            // 
            // cbUnite
            // 
            this.cbUnite.FormattingEnabled = true;
            this.cbUnite.Location = new System.Drawing.Point(68, 84);
            this.cbUnite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnite.Name = "cbUnite";
            this.cbUnite.Size = new System.Drawing.Size(39, 21);
            this.cbUnite.TabIndex = 9;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(92, 129);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 19);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(219, 129);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAjouter.Size = new System.Drawing.Size(56, 19);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrNouvelArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 176);
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
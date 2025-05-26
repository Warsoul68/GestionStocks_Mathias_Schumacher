namespace page_d_accueil
{
    partial class MouvStockFr
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
            this.lblNomArticle = new System.Windows.Forms.Label();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.lblNomDepot = new System.Windows.Forms.Label();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.dtpDateHeureMouv = new System.Windows.Forms.DateTimePicker();
            this.lblMouvStockDateHeure = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomArticle
            // 
            this.lblNomArticle.AutoSize = true;
            this.lblNomArticle.Location = new System.Drawing.Point(12, 18);
            this.lblNomArticle.Name = "lblNomArticle";
            this.lblNomArticle.Size = new System.Drawing.Size(67, 13);
            this.lblNomArticle.TabIndex = 0;
            this.lblNomArticle.Text = "Nom Article :";
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Location = new System.Drawing.Point(85, 15);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(147, 21);
            this.cboArticle.TabIndex = 1;
            // 
            // lblNomDepot
            // 
            this.lblNomDepot.AutoSize = true;
            this.lblNomDepot.Location = new System.Drawing.Point(12, 46);
            this.lblNomDepot.Name = "lblNomDepot";
            this.lblNomDepot.Size = new System.Drawing.Size(67, 13);
            this.lblNomDepot.TabIndex = 2;
            this.lblNomDepot.Text = "Nom Dépot :";
            // 
            // cboDepot
            // 
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.Location = new System.Drawing.Point(85, 43);
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(147, 21);
            this.cboDepot.TabIndex = 3;
            // 
            // dtpDateHeureMouv
            // 
            this.dtpDateHeureMouv.Location = new System.Drawing.Point(169, 75);
            this.dtpDateHeureMouv.Name = "dtpDateHeureMouv";
            this.dtpDateHeureMouv.Size = new System.Drawing.Size(181, 20);
            this.dtpDateHeureMouv.TabIndex = 4;
            // 
            // lblMouvStockDateHeure
            // 
            this.lblMouvStockDateHeure.AutoSize = true;
            this.lblMouvStockDateHeure.Location = new System.Drawing.Point(12, 75);
            this.lblMouvStockDateHeure.Name = "lblMouvStockDateHeure";
            this.lblMouvStockDateHeure.Size = new System.Drawing.Size(151, 13);
            this.lblMouvStockDateHeure.TabIndex = 5;
            this.lblMouvStockDateHeure.Text = "Date et heure du mouvement :";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(12, 105);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblQuantite.TabIndex = 6;
            this.lblQuantite.Text = "Quantité :";
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(71, 103);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(92, 20);
            this.numQuantite.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 150);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(118, 150);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(217, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Enregistrer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(303, 150);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // MouvStockFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 187);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblMouvStockDateHeure);
            this.Controls.Add(this.dtpDateHeureMouv);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.lblNomDepot);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.lblNomArticle);
            this.Name = "MouvStockFr";
            this.Text = "Gestion des mouvement de stock";
            this.Load += new System.EventHandler(this.MouvStockFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomArticle;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Label lblNomDepot;
        private System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.DateTimePicker dtpDateHeureMouv;
        private System.Windows.Forms.Label lblMouvStockDateHeure;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAjouter;
    }
}
namespace page_d_accueil
{
    partial class Inventaire
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
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lbllFiDepot = new System.Windows.Forms.Label();
            this.cbFiDepot = new System.Windows.Forms.ComboBox();
            this.lblFiVille = new System.Windows.Forms.Label();
            this.cbFiVille = new System.Windows.Forms.ComboBox();
            this.lblFiPays = new System.Windows.Forms.Label();
            this.cbFiPays = new System.Windows.Forms.ComboBox();
            this.lblFiCategorieArticle = new System.Windows.Forms.Label();
            this.cbFiCategorieArticle = new System.Windows.Forms.ComboBox();
            this.lblFiFabricant = new System.Windows.Forms.Label();
            this.cbFiFabricant = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 38);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(101, 34);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 22);
            this.txtDate.TabIndex = 1;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(29, 71);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(50, 16);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "Heure :";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(101, 68);
            this.txtHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(132, 22);
            this.txtHeure.TabIndex = 3;
            // 
            // lbllFiDepot
            // 
            this.lbllFiDepot.AutoSize = true;
            this.lbllFiDepot.Location = new System.Drawing.Point(440, 34);
            this.lbllFiDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllFiDepot.Name = "lbllFiDepot";
            this.lbllFiDepot.Size = new System.Drawing.Size(107, 16);
            this.lbllFiDepot.TabIndex = 4;
            this.lbllFiDepot.Text = "Filtrer par dépôt :";
            // 
            // cbFiDepot
            // 
            this.cbFiDepot.FormattingEnabled = true;
            this.cbFiDepot.Location = new System.Drawing.Point(563, 31);
            this.cbFiDepot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiDepot.Name = "cbFiDepot";
            this.cbFiDepot.Size = new System.Drawing.Size(160, 24);
            this.cbFiDepot.TabIndex = 5;
            // 
            // lblFiVille
            // 
            this.lblFiVille.AutoSize = true;
            this.lblFiVille.Location = new System.Drawing.Point(440, 68);
            this.lblFiVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiVille.Name = "lblFiVille";
            this.lblFiVille.Size = new System.Drawing.Size(96, 16);
            this.lblFiVille.TabIndex = 6;
            this.lblFiVille.Text = "Filtrer par ville :";
            // 
            // cbFiVille
            // 
            this.cbFiVille.FormattingEnabled = true;
            this.cbFiVille.Location = new System.Drawing.Point(563, 64);
            this.cbFiVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiVille.Name = "cbFiVille";
            this.cbFiVille.Size = new System.Drawing.Size(160, 24);
            this.cbFiVille.TabIndex = 7;
            // 
            // lblFiPays
            // 
            this.lblFiPays.AutoSize = true;
            this.lblFiPays.Location = new System.Drawing.Point(440, 103);
            this.lblFiPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiPays.Name = "lblFiPays";
            this.lblFiPays.Size = new System.Drawing.Size(102, 16);
            this.lblFiPays.TabIndex = 8;
            this.lblFiPays.Text = "Filtrer par pays :";
            // 
            // cbFiPays
            // 
            this.cbFiPays.FormattingEnabled = true;
            this.cbFiPays.Location = new System.Drawing.Point(563, 97);
            this.cbFiPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiPays.Name = "cbFiPays";
            this.cbFiPays.Size = new System.Drawing.Size(160, 24);
            this.cbFiPays.TabIndex = 9;
            // 
            // lblFiCategorieArticle
            // 
            this.lblFiCategorieArticle.AutoSize = true;
            this.lblFiCategorieArticle.Location = new System.Drawing.Point(29, 107);
            this.lblFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiCategorieArticle.Name = "lblFiCategorieArticle";
            this.lblFiCategorieArticle.Size = new System.Drawing.Size(179, 16);
            this.lblFiCategorieArticle.TabIndex = 10;
            this.lblFiCategorieArticle.Text = "Filtrer par catégorie d\'article :";
            // 
            // cbFiCategorieArticle
            // 
            this.cbFiCategorieArticle.FormattingEnabled = true;
            this.cbFiCategorieArticle.Location = new System.Drawing.Point(227, 103);
            this.cbFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiCategorieArticle.Name = "cbFiCategorieArticle";
            this.cbFiCategorieArticle.Size = new System.Drawing.Size(115, 24);
            this.cbFiCategorieArticle.TabIndex = 11;
            // 
            // lblFiFabricant
            // 
            this.lblFiFabricant.AutoSize = true;
            this.lblFiFabricant.Location = new System.Drawing.Point(261, 158);
            this.lblFiFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiFabricant.Name = "lblFiFabricant";
            this.lblFiFabricant.Size = new System.Drawing.Size(123, 16);
            this.lblFiFabricant.TabIndex = 12;
            this.lblFiFabricant.Text = "Filtrer par fabricant :";
            // 
            // cbFiFabricant
            // 
            this.cbFiFabricant.FormattingEnabled = true;
            this.cbFiFabricant.Location = new System.Drawing.Point(403, 154);
            this.cbFiFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiFabricant.Name = "cbFiFabricant";
            this.cbFiFabricant.Size = new System.Drawing.Size(160, 24);
            this.cbFiFabricant.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(721, 241);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(655, 490);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrer.TabIndex = 15;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(265, 490);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(191, 28);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider les niveaux saisis ";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(33, 490);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 554);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFiFabricant);
            this.Controls.Add(this.lblFiFabricant);
            this.Controls.Add(this.cbFiCategorieArticle);
            this.Controls.Add(this.lblFiCategorieArticle);
            this.Controls.Add(this.cbFiPays);
            this.Controls.Add(this.lblFiPays);
            this.Controls.Add(this.cbFiVille);
            this.Controls.Add(this.lblFiVille);
            this.Controls.Add(this.cbFiDepot);
            this.Controls.Add(this.lbllFiDepot);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lbllFiDepot;
        private System.Windows.Forms.ComboBox cbFiDepot;
        private System.Windows.Forms.Label lblFiVille;
        private System.Windows.Forms.ComboBox cbFiVille;
        private System.Windows.Forms.Label lblFiPays;
        private System.Windows.Forms.ComboBox cbFiPays;
        private System.Windows.Forms.Label lblFiCategorieArticle;
        private System.Windows.Forms.ComboBox cbFiCategorieArticle;
        private System.Windows.Forms.Label lblFiFabricant;
        private System.Windows.Forms.ComboBox cbFiFabricant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
namespace page_d_accueil
{
    partial class FrCategorieSupprimer
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
            this.components = new System.ComponentModel.Container();
            this.lblCodeCategorie = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbCodeCategorie = new System.Windows.Forms.ComboBox();
            this.dS_Selection_Parametre_Categorie = new page_d_accueil.DS_Selection_Parametre_Categorie();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new page_d_accueil.DS_Selection_Parametre_CategorieTableAdapters.CategorieTableAdapter();
            this.codeCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Parametre_Categorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeCategorie
            // 
            this.lblCodeCategorie.AutoSize = true;
            this.lblCodeCategorie.Location = new System.Drawing.Point(9, 15);
            this.lblCodeCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeCategorie.Name = "lblCodeCategorie";
            this.lblCodeCategorie.Size = new System.Drawing.Size(100, 13);
            this.lblCodeCategorie.TabIndex = 0;
            this.lblCodeCategorie.Text = "Code de catégorie :";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(9, 40);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(107, 40);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(122, 20);
            this.txtLibelle.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeCategorieDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categorieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(258, 129);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(28, 217);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 26);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler ";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(169, 218);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(73, 25);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cbCodeCategorie
            // 
            this.cbCodeCategorie.FormattingEnabled = true;
            this.cbCodeCategorie.Location = new System.Drawing.Point(107, 12);
            this.cbCodeCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCodeCategorie.Name = "cbCodeCategorie";
            this.cbCodeCategorie.Size = new System.Drawing.Size(122, 21);
            this.cbCodeCategorie.TabIndex = 7;
            // 
            // dS_Selection_Parametre_Categorie
            // 
            this.dS_Selection_Parametre_Categorie.DataSetName = "DS_Selection_Parametre_Categorie";
            this.dS_Selection_Parametre_Categorie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.dS_Selection_Parametre_Categorie;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // codeCategorieDataGridViewTextBoxColumn
            // 
            this.codeCategorieDataGridViewTextBoxColumn.DataPropertyName = "codeCategorie";
            this.codeCategorieDataGridViewTextBoxColumn.HeaderText = "codeCategorie";
            this.codeCategorieDataGridViewTextBoxColumn.Name = "codeCategorieDataGridViewTextBoxColumn";
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // FrCategorieSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.cbCodeCategorie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblCodeCategorie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrCategorieSupprimer";
            this.Text = "Supprimer une catégorie";
            this.Load += new System.EventHandler(this.FrCategorieSupprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Parametre_Categorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeCategorie;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cbCodeCategorie;
        private DS_Selection_Parametre_Categorie dS_Selection_Parametre_Categorie;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private DS_Selection_Parametre_CategorieTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
    }
}
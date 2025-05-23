namespace page_d_accueil
{
    partial class FrArticle
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
            this.lblReRef = new System.Windows.Forms.Label();
            this.cbReRef = new System.Windows.Forms.ComboBox();
            this.lblReLibelle = new System.Windows.Forms.Label();
            this.cbLibelleArticle = new System.Windows.Forms.ComboBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.btnPoint = new System.Windows.Forms.Button();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblFabricant = new System.Windows.Forms.Label();
            this.cbFabricant = new System.Windows.Forms.ComboBox();
            this.lblUnite = new System.Windows.Forms.Label();
            this.cbUnite = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dS_Selection_Vue_FrArticle = new page_d_accueil.DS_Selection_Vue_FrArticle();
            this.vueSelectionfrArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vue_Selection_frArticleTableAdapter = new page_d_accueil.DS_Selection_Vue_FrArticleTableAdapters.Vue_Selection_frArticleTableAdapter();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Vue_FrArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionfrArticleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReRef
            // 
            this.lblReRef.AutoSize = true;
            this.lblReRef.BackColor = System.Drawing.Color.Red;
            this.lblReRef.Location = new System.Drawing.Point(12, 21);
            this.lblReRef.Name = "lblReRef";
            this.lblReRef.Size = new System.Drawing.Size(132, 13);
            this.lblReRef.TabIndex = 0;
            this.lblReRef.Text = "Recherche par référence :";
            // 
            // cbReRef
            // 
            this.cbReRef.FormattingEnabled = true;
            this.cbReRef.Location = new System.Drawing.Point(150, 17);
            this.cbReRef.Name = "cbReRef";
            this.cbReRef.Size = new System.Drawing.Size(121, 21);
            this.cbReRef.TabIndex = 1;
            // 
            // lblReLibelle
            // 
            this.lblReLibelle.AutoSize = true;
            this.lblReLibelle.BackColor = System.Drawing.Color.Red;
            this.lblReLibelle.Location = new System.Drawing.Point(12, 47);
            this.lblReLibelle.Name = "lblReLibelle";
            this.lblReLibelle.Size = new System.Drawing.Size(113, 13);
            this.lblReLibelle.TabIndex = 2;
            this.lblReLibelle.Text = "Recherche par libellé :";
            // 
            // cbLibelleArticle
            // 
            this.cbLibelleArticle.FormattingEnabled = true;
            this.cbLibelleArticle.Location = new System.Drawing.Point(150, 44);
            this.cbLibelleArticle.Name = "cbLibelleArticle";
            this.cbLibelleArticle.Size = new System.Drawing.Size(315, 21);
            this.cbLibelleArticle.TabIndex = 3;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(12, 107);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(63, 13);
            this.lblRef.TabIndex = 5;
            this.lblRef.Text = "Référence :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(81, 104);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 6;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(187, 101);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(43, 23);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Text = "...";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(12, 141);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 8;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(81, 138);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(295, 20);
            this.txtLibelle.TabIndex = 9;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 184);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(76, 181);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 11;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(13, 215);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(57, 13);
            this.lblFabricant.TabIndex = 12;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(76, 212);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(300, 21);
            this.cbFabricant.TabIndex = 13;
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(13, 253);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(38, 13);
            this.lblUnite.TabIndex = 14;
            this.lblUnite.Text = "Unité :";
            // 
            // cbUnite
            // 
            this.cbUnite.FormattingEnabled = true;
            this.cbUnite.Location = new System.Drawing.Point(76, 250);
            this.cbUnite.Name = "cbUnite";
            this.cbUnite.Size = new System.Drawing.Size(106, 21);
            this.cbUnite.TabIndex = 15;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(26, 289);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(122, 289);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(213, 289);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dépotDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueSelectionfrArticleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(471, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(231, 205);
            this.dataGridView1.TabIndex = 19;
            // 
            // dS_Selection_Vue_FrArticle
            // 
            this.dS_Selection_Vue_FrArticle.DataSetName = "DS_Selection_Vue_FrArticle";
            this.dS_Selection_Vue_FrArticle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueSelectionfrArticleBindingSource
            // 
            this.vueSelectionfrArticleBindingSource.DataMember = "Vue_Selection_frArticle";
            this.vueSelectionfrArticleBindingSource.DataSource = this.dS_Selection_Vue_FrArticle;
            // 
            // vue_Selection_frArticleTableAdapter
            // 
            this.vue_Selection_frArticleTableAdapter.ClearBeforeFill = true;
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(495, 44);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrer.TabIndex = 0;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // FrArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbUnite);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.cbFabricant);
            this.Controls.Add(this.lblFabricant);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.cbLibelleArticle);
            this.Controls.Add(this.lblReLibelle);
            this.Controls.Add(this.cbReRef);
            this.Controls.Add(this.lblReRef);
            this.Name = "FrArticle";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.FrArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Vue_FrArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionfrArticleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReRef;
        private System.Windows.Forms.ComboBox cbReRef;
        private System.Windows.Forms.Label lblReLibelle;
        private System.Windows.Forms.ComboBox cbLibelleArticle;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblFabricant;
        private System.Windows.Forms.ComboBox cbFabricant;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.ComboBox cbUnite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Selection_Vue_FrArticle dS_Selection_Vue_FrArticle;
        private System.Windows.Forms.BindingSource vueSelectionfrArticleBindingSource;
        private DS_Selection_Vue_FrArticleTableAdapters.Vue_Selection_frArticleTableAdapter vue_Selection_frArticleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFiltrer;
    }
}
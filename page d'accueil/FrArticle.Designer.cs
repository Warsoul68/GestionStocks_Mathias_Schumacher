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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.dS_Selection_frArticle = new page_d_accueil.DS_Selection_frArticle();
            this.vuefrArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vue_frArticleTableAdapter = new page_d_accueil.DS_Selection_frArticleTableAdapters.Vue_frArticleTableAdapter();
            this.dépôtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_frArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuefrArticleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReRef
            // 
            this.lblReRef.AutoSize = true;
            this.lblReRef.BackColor = System.Drawing.Color.Red;
            this.lblReRef.Location = new System.Drawing.Point(16, 26);
            this.lblReRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReRef.Name = "lblReRef";
            this.lblReRef.Size = new System.Drawing.Size(162, 16);
            this.lblReRef.TabIndex = 0;
            this.lblReRef.Text = "Recherche par référence :";
            // 
            // cbReRef
            // 
            this.cbReRef.FormattingEnabled = true;
            this.cbReRef.Location = new System.Drawing.Point(200, 21);
            this.cbReRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbReRef.Name = "cbReRef";
            this.cbReRef.Size = new System.Drawing.Size(160, 24);
            this.cbReRef.TabIndex = 1;
            // 
            // lblReLibelle
            // 
            this.lblReLibelle.AutoSize = true;
            this.lblReLibelle.BackColor = System.Drawing.Color.Red;
            this.lblReLibelle.Location = new System.Drawing.Point(16, 58);
            this.lblReLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReLibelle.Name = "lblReLibelle";
            this.lblReLibelle.Size = new System.Drawing.Size(141, 16);
            this.lblReLibelle.TabIndex = 2;
            this.lblReLibelle.Text = "Recherche par libellé :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(419, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 111);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(16, 132);
            this.lblRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(76, 16);
            this.lblRef.TabIndex = 5;
            this.lblRef.Text = "Référence :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(108, 128);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(132, 22);
            this.txtRef.TabIndex = 6;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(249, 124);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(57, 28);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Text = "...";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(16, 174);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(53, 16);
            this.lblLibelle.TabIndex = 8;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(108, 170);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(392, 22);
            this.txtLibelle.TabIndex = 9;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(16, 226);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(72, 16);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(101, 223);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(160, 24);
            this.cbCategorie.TabIndex = 11;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(17, 265);
            this.lblFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(69, 16);
            this.lblFabricant.TabIndex = 12;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(101, 261);
            this.cbFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(399, 24);
            this.cbFabricant.TabIndex = 13;
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(17, 311);
            this.lblUnite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(44, 16);
            this.lblUnite.TabIndex = 14;
            this.lblUnite.Text = "Unité :";
            // 
            // cbUnite
            // 
            this.cbUnite.FormattingEnabled = true;
            this.cbUnite.Location = new System.Drawing.Point(101, 308);
            this.cbUnite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUnite.Name = "cbUnite";
            this.cbUnite.Size = new System.Drawing.Size(140, 24);
            this.cbUnite.TabIndex = 15;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(35, 356);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(163, 356);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(284, 356);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dépôtDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vuefrArticleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(628, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(308, 252);
            this.dataGridView1.TabIndex = 19;
            // 
            // dS_Selection_frArticle
            // 
            this.dS_Selection_frArticle.DataSetName = "DS_Selection_frArticle";
            this.dS_Selection_frArticle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vuefrArticleBindingSource
            // 
            this.vuefrArticleBindingSource.DataMember = "Vue_frArticle";
            this.vuefrArticleBindingSource.DataSource = this.dS_Selection_frArticle;
            // 
            // vue_frArticleTableAdapter
            // 
            this.vue_frArticleTableAdapter.ClearBeforeFill = true;
            // 
            // dépôtDataGridViewTextBoxColumn
            // 
            this.dépôtDataGridViewTextBoxColumn.DataPropertyName = "Dépôt";
            this.dépôtDataGridViewTextBoxColumn.HeaderText = "Dépôt";
            this.dépôtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dépôtDataGridViewTextBoxColumn.Name = "dépôtDataGridViewTextBoxColumn";
            this.dépôtDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 420);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReLibelle);
            this.Controls.Add(this.cbReRef);
            this.Controls.Add(this.lblReRef);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrArticle";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.FrArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_frArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuefrArticleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReRef;
        private System.Windows.Forms.ComboBox cbReRef;
        private System.Windows.Forms.Label lblReLibelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private DS_Selection_frArticle dS_Selection_frArticle;
        private System.Windows.Forms.BindingSource vuefrArticleBindingSource;
        private DS_Selection_frArticleTableAdapters.Vue_frArticleTableAdapter vue_frArticleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépôtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}
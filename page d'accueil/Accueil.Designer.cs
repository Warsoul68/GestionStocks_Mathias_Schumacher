namespace page_d_accueil
{
    partial class Accueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tsMenuApplication = new System.Windows.Forms.ToolStrip();
            this.tsParametres = new System.Windows.Forms.ToolStripDropDownButton();
            this.listeDesCatégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDeCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesUnitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.créationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDunitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDonnee = new System.Windows.Forms.ToolStripDropDownButton();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStock = new System.Windows.Forms.ToolStripDropDownButton();
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMultiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.lblFabricant = new System.Windows.Forms.Label();
            this.cboFabricant = new System.Windows.Forms.ComboBox();
            this.lblDepot = new System.Windows.Forms.Label();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.cboLibelle = new System.Windows.Forms.ComboBox();
            this.chkClassementDecroissant = new System.Windows.Forms.CheckBox();
            this.btnNewArticle = new System.Windows.Forms.Button();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.dS_Selection_Article = new page_d_accueil.DS_Selection_Article();
            this.vueSelectionArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vue_Selection_ArticleTableAdapter = new page_d_accueil.DS_Selection_ArticleTableAdapters.Vue_Selection_ArticleTableAdapter();
            this.référenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catégorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenuApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionArticleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuApplication
            // 
            this.tsMenuApplication.BackColor = System.Drawing.Color.Silver;
            this.tsMenuApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsParametres,
            this.tsDonnee,
            this.tsStock});
            this.tsMenuApplication.Location = new System.Drawing.Point(0, 0);
            this.tsMenuApplication.Name = "tsMenuApplication";
            this.tsMenuApplication.Size = new System.Drawing.Size(919, 27);
            this.tsMenuApplication.TabIndex = 0;
            this.tsMenuApplication.Text = "toolStrip1";
            // 
            // tsParametres
            // 
            this.tsParametres.BackColor = System.Drawing.Color.Transparent;
            this.tsParametres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCatégoriesToolStripMenuItem,
            this.listeDesUnitéToolStripMenuItem});
            this.tsParametres.Name = "tsParametres";
            this.tsParametres.Size = new System.Drawing.Size(96, 24);
            this.tsParametres.Text = "Paramètres";
            // 
            // listeDesCatégoriesToolStripMenuItem
            // 
            this.listeDesCatégoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualisationToolStripMenuItem,
            this.créationToolStripMenuItem,
            this.miseÀJourToolStripMenuItem,
            this.suppressionDeCatégorieToolStripMenuItem});
            this.listeDesCatégoriesToolStripMenuItem.Name = "listeDesCatégoriesToolStripMenuItem";
            this.listeDesCatégoriesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.listeDesCatégoriesToolStripMenuItem.Text = "Liste des catégories";
            // 
            // visualisationToolStripMenuItem
            // 
            this.visualisationToolStripMenuItem.Name = "visualisationToolStripMenuItem";
            this.visualisationToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.visualisationToolStripMenuItem.Text = "visualisation";
            this.visualisationToolStripMenuItem.Click += new System.EventHandler(this.visualisationToolStripMenuItem_Click);
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.créationToolStripMenuItem.Text = "création";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.miseÀJourToolStripMenuItem.Text = "mise à jour";
            this.miseÀJourToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourToolStripMenuItem_Click);
            // 
            // suppressionDeCatégorieToolStripMenuItem
            // 
            this.suppressionDeCatégorieToolStripMenuItem.Name = "suppressionDeCatégorieToolStripMenuItem";
            this.suppressionDeCatégorieToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.suppressionDeCatégorieToolStripMenuItem.Text = "suppression de catégorie";
            this.suppressionDeCatégorieToolStripMenuItem.Click += new System.EventHandler(this.suppressionDeCatégorieToolStripMenuItem_Click);
            // 
            // listeDesUnitéToolStripMenuItem
            // 
            this.listeDesUnitéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualisationToolStripMenuItem1,
            this.créationToolStripMenuItem1,
            this.miseÀJourToolStripMenuItem1,
            this.suppressionDunitéToolStripMenuItem});
            this.listeDesUnitéToolStripMenuItem.Name = "listeDesUnitéToolStripMenuItem";
            this.listeDesUnitéToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.listeDesUnitéToolStripMenuItem.Text = "Liste des unité";
            // 
            // visualisationToolStripMenuItem1
            // 
            this.visualisationToolStripMenuItem1.Name = "visualisationToolStripMenuItem1";
            this.visualisationToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.visualisationToolStripMenuItem1.Text = "visualisation";
            this.visualisationToolStripMenuItem1.Click += new System.EventHandler(this.visualisationToolStripMenuItem1_Click);
            // 
            // créationToolStripMenuItem1
            // 
            this.créationToolStripMenuItem1.Name = "créationToolStripMenuItem1";
            this.créationToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.créationToolStripMenuItem1.Text = "création";
            this.créationToolStripMenuItem1.Click += new System.EventHandler(this.créationToolStripMenuItem1_Click);
            // 
            // miseÀJourToolStripMenuItem1
            // 
            this.miseÀJourToolStripMenuItem1.Name = "miseÀJourToolStripMenuItem1";
            this.miseÀJourToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.miseÀJourToolStripMenuItem1.Text = "mise à jour";
            this.miseÀJourToolStripMenuItem1.Click += new System.EventHandler(this.miseÀJourToolStripMenuItem1_Click);
            // 
            // suppressionDunitéToolStripMenuItem
            // 
            this.suppressionDunitéToolStripMenuItem.Name = "suppressionDunitéToolStripMenuItem";
            this.suppressionDunitéToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.suppressionDunitéToolStripMenuItem.Text = "suppression d\'unité";
            this.suppressionDunitéToolStripMenuItem.Click += new System.EventHandler(this.suppressionDunitéToolStripMenuItem_Click);
            // 
            // tsDonnee
            // 
            this.tsDonnee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem,
            this.listeMulticritèresToolStripMenuItem});
            this.tsDonnee.Name = "tsDonnee";
            this.tsDonnee.Size = new System.Drawing.Size(81, 24);
            this.tsDonnee.Text = "Données";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(462, 26);
            this.lToolStripMenuItem.Text = "Liste multicritère de recherche d\'un fabricant";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem
            // 
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Name = "listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem";
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Size = new System.Drawing.Size(462, 26);
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Text = "Liste multicritère de recherche d\'un ensemble d\'articles";
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Click += new System.EventHandler(this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem_Click);
            // 
            // listeMulticritèresToolStripMenuItem
            // 
            this.listeMulticritèresToolStripMenuItem.Name = "listeMulticritèresToolStripMenuItem";
            this.listeMulticritèresToolStripMenuItem.Size = new System.Drawing.Size(462, 26);
            this.listeMulticritèresToolStripMenuItem.Text = "Liste multicritère de recherche d\'un ensemble de dépots";
            this.listeMulticritèresToolStripMenuItem.Click += new System.EventHandler(this.listeMulticritèresToolStripMenuItem_Click);
            // 
            // tsStock
            // 
            this.tsStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem,
            this.listeMultiToolStripMenuItem,
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem});
            this.tsStock.Name = "tsStock";
            this.tsStock.Size = new System.Drawing.Size(59, 24);
            this.tsStock.Text = "Stock";
            // 
            // listeMulticritèresDesNiveauxDeStockToolStripMenuItem
            // 
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Name = "listeMulticritèresDesNiveauxDeStockToolStripMenuItem";
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Text = "Liste multicritères des niveaux de stock";
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Click += new System.EventHandler(this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem_Click);
            // 
            // listeMultiToolStripMenuItem
            // 
            this.listeMultiToolStripMenuItem.Name = "listeMultiToolStripMenuItem";
            this.listeMultiToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.listeMultiToolStripMenuItem.Text = "Liste multicritères pour inventaire";
            this.listeMultiToolStripMenuItem.Click += new System.EventHandler(this.listeMultiToolStripMenuItem_Click);
            // 
            // listeMulticritèresDesMouvementsDeStockToolStripMenuItem
            // 
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Name = "listeMulticritèresDesMouvementsDeStockToolStripMenuItem";
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Text = "Liste multicritères des mouvements de stock";
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Click += new System.EventHandler(this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(16, 81);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(162, 16);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Recherche par catégorie :";
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(199, 78);
            this.cboCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(160, 24);
            this.cboCategorie.TabIndex = 2;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(16, 121);
            this.lblFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(156, 16);
            this.lblFabricant.TabIndex = 3;
            this.lblFabricant.Text = "Recherche par fabricant :";
            // 
            // cboFabricant
            // 
            this.cboFabricant.FormattingEnabled = true;
            this.cboFabricant.Location = new System.Drawing.Point(199, 121);
            this.cboFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFabricant.Name = "cboFabricant";
            this.cboFabricant.Size = new System.Drawing.Size(319, 24);
            this.cboFabricant.TabIndex = 4;
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(16, 160);
            this.lblDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(140, 16);
            this.lblDepot.TabIndex = 5;
            this.lblDepot.Text = "Recherche par dépôt :";
            // 
            // cboDepot
            // 
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.Location = new System.Drawing.Point(199, 160);
            this.cboDepot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(319, 24);
            this.cboDepot.TabIndex = 6;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(16, 196);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(141, 16);
            this.lblLibelle.TabIndex = 7;
            this.lblLibelle.Text = "Recherche par libellé :";
            // 
            // cboLibelle
            // 
            this.cboLibelle.FormattingEnabled = true;
            this.cboLibelle.Location = new System.Drawing.Point(199, 196);
            this.cboLibelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLibelle.Name = "cboLibelle";
            this.cboLibelle.Size = new System.Drawing.Size(397, 24);
            this.cboLibelle.TabIndex = 8;
            // 
            // chkClassementDecroissant
            // 
            this.chkClassementDecroissant.AutoSize = true;
            this.chkClassementDecroissant.Location = new System.Drawing.Point(707, 77);
            this.chkClassementDecroissant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkClassementDecroissant.Name = "chkClassementDecroissant";
            this.chkClassementDecroissant.Size = new System.Drawing.Size(173, 20);
            this.chkClassementDecroissant.TabIndex = 9;
            this.chkClassementDecroissant.Text = "Classement décroissant";
            this.chkClassementDecroissant.UseVisualStyleBackColor = true;
            // 
            // btnNewArticle
            // 
            this.btnNewArticle.Location = new System.Drawing.Point(707, 193);
            this.btnNewArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Size = new System.Drawing.Size(112, 28);
            this.btnNewArticle.TabIndex = 10;
            this.btnNewArticle.Text = "Nouvel article";
            this.btnNewArticle.UseVisualStyleBackColor = true;
            this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
            // 
            // dgvArticle
            // 
            this.dgvArticle.AutoGenerateColumns = false;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.référenceDataGridViewTextBoxColumn,
            this.libelléDataGridViewTextBoxColumn,
            this.catégorieDataGridViewTextBoxColumn,
            this.fabricantDataGridViewTextBoxColumn,
            this.unitéDataGridViewTextBoxColumn});
            this.dgvArticle.DataSource = this.vueSelectionArticleBindingSource;
            this.dgvArticle.Location = new System.Drawing.Point(19, 259);
            this.dgvArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.RowHeadersWidth = 51;
            this.dgvArticle.Size = new System.Drawing.Size(873, 258);
            this.dgvArticle.TabIndex = 11;
            // 
            // dS_Selection_Article
            // 
            this.dS_Selection_Article.DataSetName = "DS_Selection_Article";
            this.dS_Selection_Article.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueSelectionArticleBindingSource
            // 
            this.vueSelectionArticleBindingSource.DataMember = "Vue_Selection_Article";
            this.vueSelectionArticleBindingSource.DataSource = this.dS_Selection_Article;
            // 
            // vue_Selection_ArticleTableAdapter
            // 
            this.vue_Selection_ArticleTableAdapter.ClearBeforeFill = true;
            // 
            // référenceDataGridViewTextBoxColumn
            // 
            this.référenceDataGridViewTextBoxColumn.DataPropertyName = "Référence";
            this.référenceDataGridViewTextBoxColumn.HeaderText = "Référence";
            this.référenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.référenceDataGridViewTextBoxColumn.Name = "référenceDataGridViewTextBoxColumn";
            this.référenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // libelléDataGridViewTextBoxColumn
            // 
            this.libelléDataGridViewTextBoxColumn.DataPropertyName = "Libellé";
            this.libelléDataGridViewTextBoxColumn.HeaderText = "Libellé";
            this.libelléDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelléDataGridViewTextBoxColumn.Name = "libelléDataGridViewTextBoxColumn";
            this.libelléDataGridViewTextBoxColumn.Width = 125;
            // 
            // catégorieDataGridViewTextBoxColumn
            // 
            this.catégorieDataGridViewTextBoxColumn.DataPropertyName = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catégorieDataGridViewTextBoxColumn.Name = "catégorieDataGridViewTextBoxColumn";
            this.catégorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabricantDataGridViewTextBoxColumn
            // 
            this.fabricantDataGridViewTextBoxColumn.DataPropertyName = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.HeaderText = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fabricantDataGridViewTextBoxColumn.Name = "fabricantDataGridViewTextBoxColumn";
            this.fabricantDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitéDataGridViewTextBoxColumn
            // 
            this.unitéDataGridViewTextBoxColumn.DataPropertyName = "Unité";
            this.unitéDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.unitéDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitéDataGridViewTextBoxColumn.Name = "unitéDataGridViewTextBoxColumn";
            this.unitéDataGridViewTextBoxColumn.Width = 125;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 527);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.btnNewArticle);
            this.Controls.Add(this.chkClassementDecroissant);
            this.Controls.Add(this.cboLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.lblDepot);
            this.Controls.Add(this.cboFabricant);
            this.Controls.Add(this.lblFabricant);
            this.Controls.Add(this.cboCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.tsMenuApplication);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.tsMenuApplication.ResumeLayout(false);
            this.tsMenuApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionArticleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuApplication;
        private System.Windows.Forms.ToolStripDropDownButton tsParametres;
        private System.Windows.Forms.ToolStripMenuItem listeDesCatégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionDeCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesUnitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppressionDunitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsDonnee;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsStock;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresDesNiveauxDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMultiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresDesMouvementsDeStockToolStripMenuItem;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label lblFabricant;
        private System.Windows.Forms.ComboBox cboFabricant;
        private System.Windows.Forms.Label lblDepot;
        private System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.ComboBox cboLibelle;
        private System.Windows.Forms.CheckBox chkClassementDecroissant;
        private System.Windows.Forms.Button btnNewArticle;
        private System.Windows.Forms.DataGridView dgvArticle;
        private DS_Selection_Article dS_Selection_Article;
        private System.Windows.Forms.BindingSource vueSelectionArticleBindingSource;
        private DS_Selection_ArticleTableAdapters.Vue_Selection_ArticleTableAdapter vue_Selection_ArticleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn référenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catégorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitéDataGridViewTextBoxColumn;
    }
}


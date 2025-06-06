﻿namespace page_d_accueil
{
    partial class MouvStock
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
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lblFiDepot = new System.Windows.Forms.Label();
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
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateetheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catégorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueSelectionMouvStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Selection_MouvStock = new page_d_accueil.DS_Selection_MouvStock();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.vue_Selection_MouvStockTableAdapter = new page_d_accueil.DS_Selection_MouvStockTableAdapters.Vue_Selection_MouvStockTableAdapter();
            this.btnFrMouvStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionMouvStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_MouvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(70, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(22, 61);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(42, 13);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "Heure :";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(70, 58);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(100, 20);
            this.txtHeure.TabIndex = 3;
            // 
            // lblFiDepot
            // 
            this.lblFiDepot.AutoSize = true;
            this.lblFiDepot.Location = new System.Drawing.Point(313, 34);
            this.lblFiDepot.Name = "lblFiDepot";
            this.lblFiDepot.Size = new System.Drawing.Size(89, 13);
            this.lblFiDepot.TabIndex = 4;
            this.lblFiDepot.Text = "Filtrer par dépôt : ";
            // 
            // cbFiDepot
            // 
            this.cbFiDepot.FormattingEnabled = true;
            this.cbFiDepot.Location = new System.Drawing.Point(408, 31);
            this.cbFiDepot.Name = "cbFiDepot";
            this.cbFiDepot.Size = new System.Drawing.Size(121, 21);
            this.cbFiDepot.TabIndex = 5;
            // 
            // lblFiVille
            // 
            this.lblFiVille.AutoSize = true;
            this.lblFiVille.Location = new System.Drawing.Point(313, 61);
            this.lblFiVille.Name = "lblFiVille";
            this.lblFiVille.Size = new System.Drawing.Size(77, 13);
            this.lblFiVille.TabIndex = 6;
            this.lblFiVille.Text = "Filtrer par ville :";
            // 
            // cbFiVille
            // 
            this.cbFiVille.FormattingEnabled = true;
            this.cbFiVille.Location = new System.Drawing.Point(408, 61);
            this.cbFiVille.Name = "cbFiVille";
            this.cbFiVille.Size = new System.Drawing.Size(121, 21);
            this.cbFiVille.TabIndex = 7;
            // 
            // lblFiPays
            // 
            this.lblFiPays.AutoSize = true;
            this.lblFiPays.Location = new System.Drawing.Point(313, 90);
            this.lblFiPays.Name = "lblFiPays";
            this.lblFiPays.Size = new System.Drawing.Size(81, 13);
            this.lblFiPays.TabIndex = 8;
            this.lblFiPays.Text = "Filtrer par pays :";
            // 
            // cbFiPays
            // 
            this.cbFiPays.FormattingEnabled = true;
            this.cbFiPays.Location = new System.Drawing.Point(408, 87);
            this.cbFiPays.Name = "cbFiPays";
            this.cbFiPays.Size = new System.Drawing.Size(121, 21);
            this.cbFiPays.TabIndex = 9;
            // 
            // lblFiCategorieArticle
            // 
            this.lblFiCategorieArticle.AutoSize = true;
            this.lblFiCategorieArticle.Location = new System.Drawing.Point(22, 87);
            this.lblFiCategorieArticle.Name = "lblFiCategorieArticle";
            this.lblFiCategorieArticle.Size = new System.Drawing.Size(142, 13);
            this.lblFiCategorieArticle.TabIndex = 10;
            this.lblFiCategorieArticle.Text = "Filtrer par catégorie d\'article :";
            // 
            // cbFiCategorieArticle
            // 
            this.cbFiCategorieArticle.FormattingEnabled = true;
            this.cbFiCategorieArticle.Location = new System.Drawing.Point(170, 84);
            this.cbFiCategorieArticle.Name = "cbFiCategorieArticle";
            this.cbFiCategorieArticle.Size = new System.Drawing.Size(81, 21);
            this.cbFiCategorieArticle.TabIndex = 11;
            // 
            // lblFiFabricant
            // 
            this.lblFiFabricant.AutoSize = true;
            this.lblFiFabricant.Location = new System.Drawing.Point(207, 125);
            this.lblFiFabricant.Name = "lblFiFabricant";
            this.lblFiFabricant.Size = new System.Drawing.Size(100, 13);
            this.lblFiFabricant.TabIndex = 12;
            this.lblFiFabricant.Text = "Filtrer par fabricant :";
            // 
            // cbFiFabricant
            // 
            this.cbFiFabricant.FormattingEnabled = true;
            this.cbFiFabricant.Location = new System.Drawing.Point(313, 122);
            this.cbFiFabricant.Name = "cbFiFabricant";
            this.cbFiFabricant.Size = new System.Drawing.Size(121, 21);
            this.cbFiFabricant.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.dateetheureDataGridViewTextBoxColumn,
            this.dépotDataGridViewTextBoxColumn,
            this.catégorieDataGridViewTextBoxColumn,
            this.fabricantDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueSelectionMouvStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(610, 214);
            this.dataGridView1.TabIndex = 14;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // dateetheureDataGridViewTextBoxColumn
            // 
            this.dateetheureDataGridViewTextBoxColumn.DataPropertyName = "Date_et_heure";
            this.dateetheureDataGridViewTextBoxColumn.HeaderText = "Date_et_heure";
            this.dateetheureDataGridViewTextBoxColumn.Name = "dateetheureDataGridViewTextBoxColumn";
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            // 
            // catégorieDataGridViewTextBoxColumn
            // 
            this.catégorieDataGridViewTextBoxColumn.DataPropertyName = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.Name = "catégorieDataGridViewTextBoxColumn";
            // 
            // fabricantDataGridViewTextBoxColumn
            // 
            this.fabricantDataGridViewTextBoxColumn.DataPropertyName = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.HeaderText = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.Name = "fabricantDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // vueSelectionMouvStockBindingSource
            // 
            this.vueSelectionMouvStockBindingSource.DataMember = "Vue_Selection_MouvStock";
            this.vueSelectionMouvStockBindingSource.DataSource = this.dS_Selection_MouvStock;
            // 
            // dS_Selection_MouvStock
            // 
            this.dS_Selection_MouvStock.DataSetName = "DS_Selection_MouvStock";
            this.dS_Selection_MouvStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(454, 387);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrer.TabIndex = 15;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(313, 387);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 16;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(176, 387);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(34, 391);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 19);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // vue_Selection_MouvStockTableAdapter
            // 
            this.vue_Selection_MouvStockTableAdapter.ClearBeforeFill = true;
            // 
            // btnFrMouvStock
            // 
            this.btnFrMouvStock.Location = new System.Drawing.Point(482, 138);
            this.btnFrMouvStock.Name = "btnFrMouvStock";
            this.btnFrMouvStock.Size = new System.Drawing.Size(150, 23);
            this.btnFrMouvStock.TabIndex = 19;
            this.btnFrMouvStock.Text = "Gestion des mouvement";
            this.btnFrMouvStock.UseVisualStyleBackColor = true;
            this.btnFrMouvStock.Click += new System.EventHandler(this.btnFrMouvStock_Click);
            // 
            // MouvStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnFrMouvStock);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCreer);
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
            this.Controls.Add(this.lblFiDepot);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Name = "MouvStock";
            this.Text = "Mouvement de Stock";
            this.Load += new System.EventHandler(this.MouvStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionMouvStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_MouvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lblFiDepot;
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
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private DS_Selection_MouvStock dS_Selection_MouvStock;
        private System.Windows.Forms.BindingSource vueSelectionMouvStockBindingSource;
        private DS_Selection_MouvStockTableAdapters.Vue_Selection_MouvStockTableAdapter vue_Selection_MouvStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateetheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catégorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFrMouvStock;
    }
}
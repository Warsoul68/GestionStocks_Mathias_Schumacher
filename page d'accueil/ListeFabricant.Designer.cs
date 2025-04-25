namespace page_d_accueil
{
    partial class ListeFabricant
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
            this.lblReNomEntreprise = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.btnPoint = new System.Windows.Forms.Button();
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.cbReNomEntreprise = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNomEntreprise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarque = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouterFabricant = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dS_Selection_Liste_Fabricant = new page_d_accueil.DS_Selection_Liste_Fabricant();
            this.fabricantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricantTableAdapter = new page_d_accueil.DS_Selection_Liste_FabricantTableAdapters.FabricantTableAdapter();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEntrepriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Liste_Fabricant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReRef
            // 
            this.lblReRef.AutoSize = true;
            this.lblReRef.BackColor = System.Drawing.Color.Lime;
            this.lblReRef.Location = new System.Drawing.Point(15, 27);
            this.lblReRef.Name = "lblReRef";
            this.lblReRef.Size = new System.Drawing.Size(162, 16);
            this.lblReRef.TabIndex = 0;
            this.lblReRef.Text = "Recherche par référence :";
            // 
            // cbReRef
            // 
            this.cbReRef.FormattingEnabled = true;
            this.cbReRef.Location = new System.Drawing.Point(241, 23);
            this.cbReRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbReRef.Name = "cbReRef";
            this.cbReRef.Size = new System.Drawing.Size(160, 24);
            this.cbReRef.TabIndex = 1;
            // 
            // lblReNomEntreprise
            // 
            this.lblReNomEntreprise.AutoSize = true;
            this.lblReNomEntreprise.BackColor = System.Drawing.Color.Lime;
            this.lblReNomEntreprise.Location = new System.Drawing.Point(15, 65);
            this.lblReNomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReNomEntreprise.Name = "lblReNomEntreprise";
            this.lblReNomEntreprise.Size = new System.Drawing.Size(205, 16);
            this.lblReNomEntreprise.TabIndex = 2;
            this.lblReNomEntreprise.Text = "Recherche par nom d\'entreprise :";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(15, 130);
            this.lblRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(76, 16);
            this.lblRef.TabIndex = 5;
            this.lblRef.Text = "Référence :";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(145, 127);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(132, 22);
            this.txtRef.TabIndex = 6;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(287, 127);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(47, 28);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Text = "...";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Location = new System.Drawing.Point(15, 162);
            this.lblNomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(116, 16);
            this.lblNomEntreprise.TabIndex = 8;
            this.lblNomEntreprise.Text = "Nom d\'entreprise :";
            // 
            // cbReNomEntreprise
            // 
            this.cbReNomEntreprise.FormattingEnabled = true;
            this.cbReNomEntreprise.Location = new System.Drawing.Point(241, 62);
            this.cbReNomEntreprise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbReNomEntreprise.Name = "cbReNomEntreprise";
            this.cbReNomEntreprise.Size = new System.Drawing.Size(363, 24);
            this.cbReNomEntreprise.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Lime;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 103);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // txtNomEntreprise
            // 
            this.txtNomEntreprise.Location = new System.Drawing.Point(145, 159);
            this.txtNomEntreprise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomEntreprise.Name = "txtNomEntreprise";
            this.txtNomEntreprise.Size = new System.Drawing.Size(309, 22);
            this.txtNomEntreprise.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marque :";
            // 
            // cbMarque
            // 
            this.cbMarque.FormattingEnabled = true;
            this.cbMarque.Location = new System.Drawing.Point(145, 194);
            this.cbMarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.Size = new System.Drawing.Size(160, 24);
            this.cbMarque.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceDataGridViewTextBoxColumn,
            this.nomEntrepriseDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fabricantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 372);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(584, 222);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(16, 324);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(299, 324);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btnEnregistrer.TabIndex = 15;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAjouterFabricant
            // 
            this.btnAjouterFabricant.Location = new System.Drawing.Point(129, 324);
            this.btnAjouterFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterFabricant.Name = "btnAjouterFabricant";
            this.btnAjouterFabricant.Size = new System.Drawing.Size(149, 28);
            this.btnAjouterFabricant.TabIndex = 16;
            this.btnAjouterFabricant.Text = "Ajouter un fabricant";
            this.btnAjouterFabricant.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(423, 324);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // dS_Selection_Liste_Fabricant
            // 
            this.dS_Selection_Liste_Fabricant.DataSetName = "DS_Selection_Liste_Fabricant";
            this.dS_Selection_Liste_Fabricant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricantBindingSource
            // 
            this.fabricantBindingSource.DataMember = "Fabricant";
            this.fabricantBindingSource.DataSource = this.dS_Selection_Liste_Fabricant;
            // 
            // fabricantTableAdapter
            // 
            this.fabricantTableAdapter.ClearBeforeFill = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "reference";
            this.referenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomEntrepriseDataGridViewTextBoxColumn
            // 
            this.nomEntrepriseDataGridViewTextBoxColumn.DataPropertyName = "nomEntreprise";
            this.nomEntrepriseDataGridViewTextBoxColumn.HeaderText = "nomEntreprise";
            this.nomEntrepriseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomEntrepriseDataGridViewTextBoxColumn.Name = "nomEntrepriseDataGridViewTextBoxColumn";
            this.nomEntrepriseDataGridViewTextBoxColumn.Width = 125;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "marque";
            this.marqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // ListeFabricant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 607);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouterFabricant);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbMarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomEntreprise);
            this.Controls.Add(this.lblNomEntreprise);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.cbReNomEntreprise);
            this.Controls.Add(this.lblReNomEntreprise);
            this.Controls.Add(this.cbReRef);
            this.Controls.Add(this.lblReRef);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListeFabricant";
            this.Text = "Liste des fabricants";
            this.Load += new System.EventHandler(this.ListeFabricant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Liste_Fabricant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReRef;
        private System.Windows.Forms.ComboBox cbReRef;
        private System.Windows.Forms.Label lblReNomEntreprise;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.ComboBox cbReNomEntreprise;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtNomEntreprise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouterFabricant;
        private System.Windows.Forms.Button btnSupprimer;
        private DS_Selection_Liste_Fabricant dS_Selection_Liste_Fabricant;
        private System.Windows.Forms.BindingSource fabricantBindingSource;
        private DS_Selection_Liste_FabricantTableAdapters.FabricantTableAdapter fabricantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEntrepriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
    }
}
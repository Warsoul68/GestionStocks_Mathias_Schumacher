namespace page_d_accueil
{
    partial class ListeDepot
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
            this.lblNumDepotRe = new System.Windows.Forms.Label();
            this.lblVilleRe = new System.Windows.Forms.Label();
            this.cbNumDepotRe = new System.Windows.Forms.ComboBox();
            this.cbVilleRe = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSelectionListedepotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Selection_Liste_depot = new page_d_accueil.DS_Selection_Liste_depot();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.depotTableAdapter = new page_d_accueil.DS_Selection_Liste_depotTableAdapters.DepotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSelectionListedepotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Liste_depot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumDepotRe
            // 
            this.lblNumDepotRe.AutoSize = true;
            this.lblNumDepotRe.Location = new System.Drawing.Point(12, 18);
            this.lblNumDepotRe.Name = "lblNumDepotRe";
            this.lblNumDepotRe.Size = new System.Drawing.Size(122, 13);
            this.lblNumDepotRe.TabIndex = 0;
            this.lblNumDepotRe.Text = "Recherche par numéro :";
            // 
            // lblVilleRe
            // 
            this.lblVilleRe.AutoSize = true;
            this.lblVilleRe.Location = new System.Drawing.Point(12, 44);
            this.lblVilleRe.Name = "lblVilleRe";
            this.lblVilleRe.Size = new System.Drawing.Size(108, 13);
            this.lblVilleRe.TabIndex = 2;
            this.lblVilleRe.Text = "Recherche par ville : ";
            // 
            // cbNumDepotRe
            // 
            this.cbNumDepotRe.FormattingEnabled = true;
            this.cbNumDepotRe.Location = new System.Drawing.Point(140, 15);
            this.cbNumDepotRe.Name = "cbNumDepotRe";
            this.cbNumDepotRe.Size = new System.Drawing.Size(39, 21);
            this.cbNumDepotRe.TabIndex = 3;
            // 
            // cbVilleRe
            // 
            this.cbVilleRe.FormattingEnabled = true;
            this.cbVilleRe.Location = new System.Drawing.Point(140, 41);
            this.cbVilleRe.Name = "cbVilleRe";
            this.cbVilleRe.Size = new System.Drawing.Size(106, 21);
            this.cbVilleRe.TabIndex = 4;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(314, 39);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(29, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(70, 87);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(97, 20);
            this.txtNom.TabIndex = 7;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(29, 124);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(67, 121);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 9;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(29, 156);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(36, 13);
            this.lblPays.TabIndex = 10;
            this.lblPays.Text = "Pays :";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(71, 153);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(96, 20);
            this.txtPays.TabIndex = 11;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(29, 207);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text = "Latitude :";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(86, 204);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(136, 20);
            this.txtLatitude.TabIndex = 13;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(30, 239);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(60, 13);
            this.lblLongitude.TabIndex = 14;
            this.lblLongitude.Text = "Longitude :";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(96, 236);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(150, 20);
            this.txtLongitude.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.depotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 138);
            this.dataGridView1.TabIndex = 16;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // paysDataGridViewTextBoxColumn
            // 
            this.paysDataGridViewTextBoxColumn.DataPropertyName = "pays";
            this.paysDataGridViewTextBoxColumn.HeaderText = "pays";
            this.paysDataGridViewTextBoxColumn.Name = "paysDataGridViewTextBoxColumn";
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            // 
            // depotBindingSource
            // 
            this.depotBindingSource.DataMember = "Depot";
            this.depotBindingSource.DataSource = this.dSSelectionListedepotBindingSource;
            // 
            // dSSelectionListedepotBindingSource
            // 
            this.dSSelectionListedepotBindingSource.DataSource = this.dS_Selection_Liste_depot;
            this.dSSelectionListedepotBindingSource.Position = 0;
            // 
            // dS_Selection_Liste_depot
            // 
            this.dS_Selection_Liste_depot.DataSetName = "DS_Selection_Liste_depot";
            this.dS_Selection_Liste_depot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(15, 284);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(118, 284);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(104, 23);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter un dépot";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(257, 284);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(370, 284);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // depotTableAdapter
            // 
            this.depotTableAdapter.ClearBeforeFill = true;
            // 
            // ListeDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 463);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.cbVilleRe);
            this.Controls.Add(this.cbNumDepotRe);
            this.Controls.Add(this.lblVilleRe);
            this.Controls.Add(this.lblNumDepotRe);
            this.Name = "ListeDepot";
            this.Text = "Liste des dépots";
            this.Load += new System.EventHandler(this.ListeDepot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSelectionListedepotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Liste_depot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDepotRe;
        private System.Windows.Forms.Label lblVilleRe;
        private System.Windows.Forms.ComboBox cbNumDepotRe;
        private System.Windows.Forms.ComboBox cbVilleRe;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource dSSelectionListedepotBindingSource;
        private DS_Selection_Liste_depot dS_Selection_Liste_depot;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource depotBindingSource;
        private DS_Selection_Liste_depotTableAdapters.DepotTableAdapter depotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
    }
}
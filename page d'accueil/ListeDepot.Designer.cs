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
            this.lblReVille = new System.Windows.Forms.Label();
            this.lblReNum = new System.Windows.Forms.Label();
            this.cbRePays = new System.Windows.Forms.ComboBox();
            this.cbReVille = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterDepot = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReVille
            // 
            this.lblReVille.AutoSize = true;
            this.lblReVille.BackColor = System.Drawing.Color.Blue;
            this.lblReVille.ForeColor = System.Drawing.Color.White;
            this.lblReVille.Location = new System.Drawing.Point(16, 44);
            this.lblReVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReVille.Name = "lblReVille";
            this.lblReVille.Size = new System.Drawing.Size(129, 16);
            this.lblReVille.TabIndex = 0;
            this.lblReVille.Text = "Recherche par ville :";
            // 
            // lblReNum
            // 
            this.lblReNum.AutoSize = true;
            this.lblReNum.BackColor = System.Drawing.Color.Blue;
            this.lblReNum.ForeColor = System.Drawing.Color.White;
            this.lblReNum.Location = new System.Drawing.Point(16, 11);
            this.lblReNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReNum.Name = "lblReNum";
            this.lblReNum.Size = new System.Drawing.Size(150, 16);
            this.lblReNum.TabIndex = 1;
            this.lblReNum.Text = "Recherche par numéro :";
            // 
            // cbRePays
            // 
            this.cbRePays.FormattingEnabled = true;
            this.cbRePays.Location = new System.Drawing.Point(169, 7);
            this.cbRePays.Margin = new System.Windows.Forms.Padding(4);
            this.cbRePays.Name = "cbRePays";
            this.cbRePays.Size = new System.Drawing.Size(199, 24);
            this.cbRePays.TabIndex = 2;
            // 
            // cbReVille
            // 
            this.cbReVille.FormattingEnabled = true;
            this.cbReVille.Location = new System.Drawing.Point(169, 44);
            this.cbReVille.Margin = new System.Windows.Forms.Padding(4);
            this.cbReVille.Name = "cbReVille";
            this.cbReVille.Size = new System.Drawing.Size(293, 24);
            this.cbReVille.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(32, 100);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(88, 96);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(211, 22);
            this.txtNom.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 81);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(32, 163);
            this.lblPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(44, 16);
            this.lblPays.TabIndex = 8;
            this.lblPays.Text = "Pays :";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(84, 163);
            this.txtPays.Margin = new System.Windows.Forms.Padding(4);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(177, 22);
            this.txtPays.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(571, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(269, 274);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(36, 334);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouterDepot
            // 
            this.btnAjouterDepot.Location = new System.Drawing.Point(169, 334);
            this.btnAjouterDepot.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterDepot.Name = "btnAjouterDepot";
            this.btnAjouterDepot.Size = new System.Drawing.Size(135, 28);
            this.btnAjouterDepot.TabIndex = 18;
            this.btnAjouterDepot.Text = "Ajouter un dépot";
            this.btnAjouterDepot.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(324, 334);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(445, 334);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(33, 132);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(39, 16);
            this.lblVille.TabIndex = 21;
            this.lblVille.Text = "Ville :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(78, 132);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(183, 22);
            this.txtVille.TabIndex = 22;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(32, 213);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(60, 16);
            this.lblLatitude.TabIndex = 23;
            this.lblLatitude.Text = "Latitude :";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(98, 210);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(212, 22);
            this.txtLatitude.TabIndex = 24;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(33, 255);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(72, 16);
            this.lblLongitude.TabIndex = 25;
            this.lblLongitude.Text = "Longitude :";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(111, 252);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(199, 22);
            this.txtLongitude.TabIndex = 26;
            // 
            // ListeDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 394);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjouterDepot);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cbReVille);
            this.Controls.Add(this.cbRePays);
            this.Controls.Add(this.lblReNum);
            this.Controls.Add(this.lblReVille);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeDepot";
            this.Text = "Liste des dépots";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReVille;
        private System.Windows.Forms.Label lblReNum;
        private System.Windows.Forms.ComboBox cbRePays;
        private System.Windows.Forms.ComboBox cbReVille;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterDepot;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitude;
    }
}
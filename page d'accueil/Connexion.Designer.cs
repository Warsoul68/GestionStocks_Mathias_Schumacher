namespace page_d_accueil
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConnexion.Location = new System.Drawing.Point(12, 162);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(121, 17);
            this.lblConnexion.TabIndex = 1;
            this.lblConnexion.Text = "Nom d\'utilisateur :";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(130, 162);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtUtilisateur.TabIndex = 2;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMdp.Location = new System.Drawing.Point(12, 194);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(101, 17);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(130, 194);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 5;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(130, 228);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(100, 23);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(38, 228);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 263);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
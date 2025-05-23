namespace GestionStocks_Mathias_Schumacher
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.ImgIcone = new System.Windows.Forms.PictureBox();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgIcone
            // 
            this.ImgIcone.Image = ((System.Drawing.Image)(resources.GetObject("ImgIcone.Image")));
            this.ImgIcone.Location = new System.Drawing.Point(87, 12);
            this.ImgIcone.Name = "ImgIcone";
            this.ImgIcone.Size = new System.Drawing.Size(124, 130);
            this.ImgIcone.TabIndex = 0;
            this.ImgIcone.TabStop = false;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomUtilisateur.Location = new System.Drawing.Point(33, 158);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(121, 17);
            this.lblNomUtilisateur.TabIndex = 1;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMdp.Location = new System.Drawing.Point(33, 188);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(101, 17);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(155, 158);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtNomUtilisateur.TabIndex = 3;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(140, 188);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 230);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblNomUtilisateur);
            this.Controls.Add(this.ImgIcone);
            this.Name = "Form1";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgIcone;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMdp;
    }
}


namespace ppeGUI
{
    partial class AuthentificationForm
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
            this.ValiderAuth = new System.Windows.Forms.Button();
            this.IdentifiantText = new System.Windows.Forms.TextBox();
            this.MdpText = new System.Windows.Forms.TextBox();
            this.identifiant = new System.Windows.Forms.Label();
            this.MotDePasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValiderAuth
            // 
            this.ValiderAuth.Location = new System.Drawing.Point(335, 273);
            this.ValiderAuth.Name = "ValiderAuth";
            this.ValiderAuth.Size = new System.Drawing.Size(124, 50);
            this.ValiderAuth.TabIndex = 0;
            this.ValiderAuth.Text = "Connexion";
            this.ValiderAuth.UseVisualStyleBackColor = true;
            // 
            // IdentifiantText
            // 
            this.IdentifiantText.Location = new System.Drawing.Point(281, 112);
            this.IdentifiantText.Name = "IdentifiantText";
            this.IdentifiantText.Size = new System.Drawing.Size(185, 22);
            this.IdentifiantText.TabIndex = 1;
            // 
            // MdpText
            // 
            this.MdpText.Location = new System.Drawing.Point(281, 168);
            this.MdpText.Name = "MdpText";
            this.MdpText.Size = new System.Drawing.Size(185, 22);
            this.MdpText.TabIndex = 2;
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(177, 112);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(77, 17);
            this.identifiant.TabIndex = 3;
            this.identifiant.Text = "Identifiant :";
            this.identifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSize = true;
            this.MotDePasse.Location = new System.Drawing.Point(150, 168);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(104, 17);
            this.MotDePasse.TabIndex = 4;
            this.MotDePasse.Text = "Mot De Passe :";
            // 
            // AuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.MdpText);
            this.Controls.Add(this.IdentifiantText);
            this.Controls.Add(this.ValiderAuth);
            this.Name = "AuthentificationForm";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValiderAuth;
        private System.Windows.Forms.TextBox IdentifiantText;
        private System.Windows.Forms.TextBox MdpText;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label MotDePasse;
    }
}


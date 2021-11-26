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
            this.ValiderAuth.Location = new System.Drawing.Point(251, 222);
            this.ValiderAuth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValiderAuth.Name = "ValiderAuth";
            this.ValiderAuth.Size = new System.Drawing.Size(93, 41);
            this.ValiderAuth.TabIndex = 0;
            this.ValiderAuth.Text = "Connexion";
            this.ValiderAuth.UseVisualStyleBackColor = true;
            this.ValiderAuth.Click += new System.EventHandler(this.test);
            // 
            // IdentifiantText
            // 
            this.IdentifiantText.Location = new System.Drawing.Point(211, 91);
            this.IdentifiantText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdentifiantText.Name = "IdentifiantText";
            this.IdentifiantText.Size = new System.Drawing.Size(140, 20);
            this.IdentifiantText.TabIndex = 1;
            // 
            // MdpText
            // 
            this.MdpText.Location = new System.Drawing.Point(211, 136);
            this.MdpText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MdpText.Name = "MdpText";
            this.MdpText.Size = new System.Drawing.Size(140, 20);
            this.MdpText.TabIndex = 2;
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(133, 91);
            this.identifiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(59, 13);
            this.identifiant.TabIndex = 3;
            this.identifiant.Text = "Identifiant :";
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSize = true;
            this.MotDePasse.Location = new System.Drawing.Point(112, 136);
            this.MotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(80, 13);
            this.MotDePasse.TabIndex = 4;
            this.MotDePasse.Text = "Mot De Passe :";
            // 
            // AuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.MdpText);
            this.Controls.Add(this.IdentifiantText);
            this.Controls.Add(this.ValiderAuth);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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


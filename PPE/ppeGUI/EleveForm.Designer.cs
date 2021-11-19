namespace ppeGUI
{
    partial class EleveForm
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
            this.RetourBtn = new System.Windows.Forms.Button();
            this.SuppBtn = new System.Windows.Forms.Button();
            this.ConsulterBtn = new System.Windows.Forms.Button();
            this.AjtBtn = new System.Windows.Forms.Button();
            this.ModifBtn = new System.Windows.Forms.Button();
            this.NomEleveText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEleve = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RetourBtn
            // 
            this.RetourBtn.Location = new System.Drawing.Point(685, 395);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(103, 43);
            this.RetourBtn.TabIndex = 0;
            this.RetourBtn.Text = "Retour";
            this.RetourBtn.UseVisualStyleBackColor = true;
            // 
            // SuppBtn
            // 
            this.SuppBtn.Location = new System.Drawing.Point(521, 117);
            this.SuppBtn.Name = "SuppBtn";
            this.SuppBtn.Size = new System.Drawing.Size(99, 44);
            this.SuppBtn.TabIndex = 1;
            this.SuppBtn.Text = "Supprimer";
            this.SuppBtn.UseVisualStyleBackColor = true;
            // 
            // ConsulterBtn
            // 
            this.ConsulterBtn.Location = new System.Drawing.Point(377, 117);
            this.ConsulterBtn.Name = "ConsulterBtn";
            this.ConsulterBtn.Size = new System.Drawing.Size(111, 44);
            this.ConsulterBtn.TabIndex = 2;
            this.ConsulterBtn.Text = "Consulter";
            this.ConsulterBtn.UseVisualStyleBackColor = true;
            // 
            // AjtBtn
            // 
            this.AjtBtn.Location = new System.Drawing.Point(377, 167);
            this.AjtBtn.Name = "AjtBtn";
            this.AjtBtn.Size = new System.Drawing.Size(111, 49);
            this.AjtBtn.TabIndex = 3;
            this.AjtBtn.Text = "Ajouter";
            this.AjtBtn.UseVisualStyleBackColor = true;
            // 
            // ModifBtn
            // 
            this.ModifBtn.Location = new System.Drawing.Point(521, 167);
            this.ModifBtn.Name = "ModifBtn";
            this.ModifBtn.Size = new System.Drawing.Size(99, 49);
            this.ModifBtn.TabIndex = 4;
            this.ModifBtn.Text = "Modifier";
            this.ModifBtn.UseVisualStyleBackColor = true;
            // 
            // NomEleveText
            // 
            this.NomEleveText.Location = new System.Drawing.Point(377, 49);
            this.NomEleveText.Name = "NomEleveText";
            this.NomEleveText.Size = new System.Drawing.Size(250, 22);
            this.NomEleveText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom Eleve :";
            // 
            // listEleve
            // 
            this.listEleve.FormattingEnabled = true;
            this.listEleve.ItemHeight = 16;
            this.listEleve.Location = new System.Drawing.Point(12, 29);
            this.listEleve.Name = "listEleve";
            this.listEleve.Size = new System.Drawing.Size(228, 404);
            this.listEleve.TabIndex = 7;
            // 
            // EleveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomEleveText);
            this.Controls.Add(this.ModifBtn);
            this.Controls.Add(this.AjtBtn);
            this.Controls.Add(this.ConsulterBtn);
            this.Controls.Add(this.SuppBtn);
            this.Controls.Add(this.RetourBtn);
            this.Name = "EleveForm";
            this.Text = "Eleves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Button SuppBtn;
        private System.Windows.Forms.Button ConsulterBtn;
        private System.Windows.Forms.Button AjtBtn;
        private System.Windows.Forms.Button ModifBtn;
        private System.Windows.Forms.TextBox NomEleveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEleve;
    }
}
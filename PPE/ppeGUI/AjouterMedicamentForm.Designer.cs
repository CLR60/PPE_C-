namespace ppeGUI
{
    partial class AjouterMedicamentForm
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NomMedicText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(559, 387);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(106, 51);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Enregister le médicament";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // RetourBtn
            // 
            this.RetourBtn.Location = new System.Drawing.Point(680, 387);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(108, 51);
            this.RetourBtn.TabIndex = 1;
            this.RetourBtn.Text = "Retour";
            this.RetourBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saisir le nom du médicament :";
            // 
            // NomMedicText
            // 
            this.NomMedicText.Location = new System.Drawing.Point(288, 247);
            this.NomMedicText.Name = "NomMedicText";
            this.NomMedicText.Size = new System.Drawing.Size(100, 22);
            this.NomMedicText.TabIndex = 3;
            // 
            // AjouterMedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NomMedicText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "AjouterMedicamentForm";
            this.Text = "Ajouter un médicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomMedicText;
    }
}
namespace ppeGUI
{
    partial class PageAcceuilForm
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
            this.EleveBtn = new System.Windows.Forms.Button();
            this.Visitebtn = new System.Windows.Forms.Button();
            this.MedicamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EleveBtn
            // 
            this.EleveBtn.Location = new System.Drawing.Point(68, 151);
            this.EleveBtn.Name = "EleveBtn";
            this.EleveBtn.Size = new System.Drawing.Size(165, 63);
            this.EleveBtn.TabIndex = 0;
            this.EleveBtn.Text = "Eleves";
            this.EleveBtn.UseVisualStyleBackColor = true;
            // 
            // Visitebtn
            // 
            this.Visitebtn.Location = new System.Drawing.Point(324, 151);
            this.Visitebtn.Name = "Visitebtn";
            this.Visitebtn.Size = new System.Drawing.Size(167, 63);
            this.Visitebtn.TabIndex = 1;
            this.Visitebtn.Text = "Visites";
            this.Visitebtn.UseVisualStyleBackColor = true;
            // 
            // MedicamentBtn
            // 
            this.MedicamentBtn.Location = new System.Drawing.Point(583, 151);
            this.MedicamentBtn.Name = "MedicamentBtn";
            this.MedicamentBtn.Size = new System.Drawing.Size(156, 63);
            this.MedicamentBtn.TabIndex = 2;
            this.MedicamentBtn.Text = "Medicaments";
            this.MedicamentBtn.UseVisualStyleBackColor = true;
            // 
            // PageAcceuilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedicamentBtn);
            this.Controls.Add(this.Visitebtn);
            this.Controls.Add(this.EleveBtn);
            this.Name = "PageAcceuilForm";
            this.Text = "Page d\'acceuil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EleveBtn;
        private System.Windows.Forms.Button Visitebtn;
        private System.Windows.Forms.Button MedicamentBtn;
    }
}
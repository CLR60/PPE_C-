namespace ppeGUI
{
    partial class ModifierEleveForm
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
            this.NomEleveModifText = new System.Windows.Forms.TextBox();
            this.PrenomModifEleveText = new System.Windows.Forms.TextBox();
            this.DateModifText = new System.Windows.Forms.TextBox();
            this.ClasseModifText = new System.Windows.Forms.TextBox();
            this.SanteModifText = new System.Windows.Forms.TextBox();
            this.TelPModiText = new System.Windows.Forms.TextBox();
            this.TelEModifText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomEleveModifText
            // 
            this.NomEleveModifText.Location = new System.Drawing.Point(144, 44);
            this.NomEleveModifText.Name = "NomEleveModifText";
            this.NomEleveModifText.Size = new System.Drawing.Size(134, 22);
            this.NomEleveModifText.TabIndex = 0;
            // 
            // PrenomModifEleveText
            // 
            this.PrenomModifEleveText.Location = new System.Drawing.Point(508, 44);
            this.PrenomModifEleveText.Name = "PrenomModifEleveText";
            this.PrenomModifEleveText.Size = new System.Drawing.Size(136, 22);
            this.PrenomModifEleveText.TabIndex = 1;
            // 
            // DateModifText
            // 
            this.DateModifText.Location = new System.Drawing.Point(358, 148);
            this.DateModifText.Name = "DateModifText";
            this.DateModifText.Size = new System.Drawing.Size(153, 22);
            this.DateModifText.TabIndex = 2;
            this.DateModifText.TextChanged += new System.EventHandler(this.DateModifText_TextChanged);
            // 
            // ClasseModifText
            // 
            this.ClasseModifText.Location = new System.Drawing.Point(358, 105);
            this.ClasseModifText.Name = "ClasseModifText";
            this.ClasseModifText.Size = new System.Drawing.Size(153, 22);
            this.ClasseModifText.TabIndex = 3;
            // 
            // SanteModifText
            // 
            this.SanteModifText.Location = new System.Drawing.Point(358, 189);
            this.SanteModifText.Name = "SanteModifText";
            this.SanteModifText.Size = new System.Drawing.Size(153, 22);
            this.SanteModifText.TabIndex = 4;
            // 
            // TelPModiText
            // 
            this.TelPModiText.Location = new System.Drawing.Point(144, 282);
            this.TelPModiText.Name = "TelPModiText";
            this.TelPModiText.Size = new System.Drawing.Size(134, 22);
            this.TelPModiText.TabIndex = 5;
            // 
            // TelEModifText
            // 
            this.TelEModifText.Location = new System.Drawing.Point(508, 282);
            this.TelEModifText.Name = "TelEModifText";
            this.TelEModifText.Size = new System.Drawing.Size(136, 22);
            this.TelEModifText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Classe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Santé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Téléphone Parent :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Téléphone Eleve :";
            // 
            // RetourBtn
            // 
            this.RetourBtn.Location = new System.Drawing.Point(683, 388);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(105, 46);
            this.RetourBtn.TabIndex = 14;
            this.RetourBtn.Text = "Retour";
            this.RetourBtn.UseVisualStyleBackColor = true;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(550, 388);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(104, 46);
            this.ModifierBtn.TabIndex = 15;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            // 
            // ModifierEleveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelEModifText);
            this.Controls.Add(this.TelPModiText);
            this.Controls.Add(this.SanteModifText);
            this.Controls.Add(this.ClasseModifText);
            this.Controls.Add(this.DateModifText);
            this.Controls.Add(this.PrenomModifEleveText);
            this.Controls.Add(this.NomEleveModifText);
            this.Name = "ModifierEleveForm";
            this.Text = "Modifier un eleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomEleveModifText;
        private System.Windows.Forms.TextBox PrenomModifEleveText;
        private System.Windows.Forms.TextBox DateModifText;
        private System.Windows.Forms.TextBox ClasseModifText;
        private System.Windows.Forms.TextBox SanteModifText;
        private System.Windows.Forms.TextBox TelPModiText;
        private System.Windows.Forms.TextBox TelEModifText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Button ModifierBtn;
    }
}
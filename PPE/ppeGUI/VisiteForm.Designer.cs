namespace ppeGUI
{
    partial class VisiteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AjouterVisiteBtn = new System.Windows.Forms.Button();
            this.ModifierVisiteBtn = new System.Windows.Forms.Button();
            this.ConsulterVisiteBtn = new System.Windows.Forms.Button();
            this.SupprimerVisiteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mois :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // RetourBtn
            // 
            this.RetourBtn.Location = new System.Drawing.Point(690, 399);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(98, 39);
            this.RetourBtn.TabIndex = 5;
            this.RetourBtn.Text = "Retour";
            this.RetourBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 8;
            // 
            // AjouterVisiteBtn
            // 
            this.AjouterVisiteBtn.Location = new System.Drawing.Point(364, 263);
            this.AjouterVisiteBtn.Name = "AjouterVisiteBtn";
            this.AjouterVisiteBtn.Size = new System.Drawing.Size(99, 40);
            this.AjouterVisiteBtn.TabIndex = 9;
            this.AjouterVisiteBtn.Text = "Ajouter";
            this.AjouterVisiteBtn.UseVisualStyleBackColor = true;
            // 
            // ModifierVisiteBtn
            // 
            this.ModifierVisiteBtn.Location = new System.Drawing.Point(469, 263);
            this.ModifierVisiteBtn.Name = "ModifierVisiteBtn";
            this.ModifierVisiteBtn.Size = new System.Drawing.Size(89, 40);
            this.ModifierVisiteBtn.TabIndex = 10;
            this.ModifierVisiteBtn.Text = "Modifier";
            this.ModifierVisiteBtn.UseVisualStyleBackColor = true;
            // 
            // ConsulterVisiteBtn
            // 
            this.ConsulterVisiteBtn.Location = new System.Drawing.Point(364, 309);
            this.ConsulterVisiteBtn.Name = "ConsulterVisiteBtn";
            this.ConsulterVisiteBtn.Size = new System.Drawing.Size(99, 38);
            this.ConsulterVisiteBtn.TabIndex = 11;
            this.ConsulterVisiteBtn.Text = "Consulter";
            this.ConsulterVisiteBtn.UseVisualStyleBackColor = true;
            // 
            // SupprimerVisiteBtn
            // 
            this.SupprimerVisiteBtn.Location = new System.Drawing.Point(469, 309);
            this.SupprimerVisiteBtn.Name = "SupprimerVisiteBtn";
            this.SupprimerVisiteBtn.Size = new System.Drawing.Size(89, 38);
            this.SupprimerVisiteBtn.TabIndex = 12;
            this.SupprimerVisiteBtn.Text = "Supprimer";
            this.SupprimerVisiteBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(302, 426);
            this.dataGridView1.TabIndex = 13;
            // 
            // VisiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SupprimerVisiteBtn);
            this.Controls.Add(this.ConsulterVisiteBtn);
            this.Controls.Add(this.ModifierVisiteBtn);
            this.Controls.Add(this.AjouterVisiteBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VisiteForm";
            this.Text = "Visite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AjouterVisiteBtn;
        private System.Windows.Forms.Button ModifierVisiteBtn;
        private System.Windows.Forms.Button ConsulterVisiteBtn;
        private System.Windows.Forms.Button SupprimerVisiteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
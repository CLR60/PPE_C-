
namespace PPE_C_Sharp_GUI
{
    partial class Medicament
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_mdf_med = new System.Windows.Forms.TextBox();
            this.btn_link_acl = new System.Windows.Forms.Button();
            this.lst_mdf_med = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_med = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lst_spr_med = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 650);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_mdf_med
            // 
            this.txt_mdf_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_mdf_med.Location = new System.Drawing.Point(695, 101);
            this.txt_mdf_med.Name = "txt_mdf_med";
            this.txt_mdf_med.Size = new System.Drawing.Size(211, 41);
            this.txt_mdf_med.TabIndex = 1;
            // 
            // btn_link_acl
            // 
            this.btn_link_acl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_acl.Location = new System.Drawing.Point(12, 668);
            this.btn_link_acl.Name = "btn_link_acl";
            this.btn_link_acl.Size = new System.Drawing.Size(330, 41);
            this.btn_link_acl.TabIndex = 3;
            this.btn_link_acl.Text = "Retour";
            this.btn_link_acl.UseVisualStyleBackColor = true;
            this.btn_link_acl.Click += new System.EventHandler(this.btn_link_acl_Click);
            // 
            // lst_mdf_med
            // 
            this.lst_mdf_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_mdf_med.FormattingEnabled = true;
            this.lst_mdf_med.Location = new System.Drawing.Point(434, 101);
            this.lst_mdf_med.Name = "lst_mdf_med";
            this.lst_mdf_med.Size = new System.Drawing.Size(211, 44);
            this.lst_mdf_med.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(501, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.Location = new System.Drawing.Point(501, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ajout de médicament";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txt_med
            // 
            this.txt_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_med.Location = new System.Drawing.Point(501, 330);
            this.txt_med.Name = "txt_med";
            this.txt_med.Size = new System.Drawing.Size(330, 41);
            this.txt_med.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(471, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(396, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Supprimer un médicament";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lst_spr_med
            // 
            this.lst_spr_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_spr_med.FormattingEnabled = true;
            this.lst_spr_med.Location = new System.Drawing.Point(501, 498);
            this.lst_spr_med.Name = "lst_spr_med";
            this.lst_spr_med.Size = new System.Drawing.Size(330, 44);
            this.lst_spr_med.TabIndex = 9;
            // 
            // Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lst_spr_med);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_med);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_mdf_med);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.txt_mdf_med);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medicament";
            this.Text = "Médicament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_mdf_med;
        private System.Windows.Forms.Button btn_link_acl;
        private System.Windows.Forms.ComboBox lst_mdf_med;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_med;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox lst_spr_med;
    }
}
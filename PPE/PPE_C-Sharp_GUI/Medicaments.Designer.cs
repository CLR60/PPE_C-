
namespace PPE_C_Sharp_GUI
{
    partial class Medicaments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_med = new System.Windows.Forms.DataGridView();
            this.txt_mdf_med = new System.Windows.Forms.TextBox();
            this.btn_link_acl = new System.Windows.Forms.Button();
            this.lst_mdf_med = new System.Windows.Forms.ComboBox();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_ajt = new System.Windows.Forms.Button();
            this.txt_med = new System.Windows.Forms.TextBox();
            this.btn_spr = new System.Windows.Forms.Button();
            this.lst_spr_med = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_med)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_med
            // 
            this.grid_med.AllowUserToAddRows = false;
            this.grid_med.AllowUserToDeleteRows = false;
            this.grid_med.AllowUserToResizeColumns = false;
            this.grid_med.AllowUserToResizeRows = false;
            this.grid_med.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_med.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_med.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_med.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_med.Location = new System.Drawing.Point(12, 12);
            this.grid_med.MultiSelect = false;
            this.grid_med.Name = "grid_med";
            this.grid_med.RowHeadersVisible = false;
            this.grid_med.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_med.RowTemplate.Height = 24;
            this.grid_med.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_med.ShowCellErrors = false;
            this.grid_med.ShowEditingIcon = false;
            this.grid_med.ShowRowErrors = false;
            this.grid_med.Size = new System.Drawing.Size(330, 650);
            this.grid_med.TabIndex = 1;
            // 
            // txt_mdf_med
            // 
            this.txt_mdf_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_mdf_med.Location = new System.Drawing.Point(693, 101);
            this.txt_mdf_med.Name = "txt_mdf_med";
            this.txt_mdf_med.Size = new System.Drawing.Size(211, 41);
            this.txt_mdf_med.TabIndex = 3;
            this.txt_mdf_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mdf_med_KeyPress);
            // 
            // btn_link_acl
            // 
            this.btn_link_acl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_acl.Location = new System.Drawing.Point(12, 668);
            this.btn_link_acl.Name = "btn_link_acl";
            this.btn_link_acl.Size = new System.Drawing.Size(330, 41);
            this.btn_link_acl.TabIndex = 9;
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
            this.lst_mdf_med.TabIndex = 2;
            // 
            // btn_mdf
            // 
            this.btn_mdf.AutoSize = true;
            this.btn_mdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_mdf.Location = new System.Drawing.Point(600, 151);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(132, 46);
            this.btn_mdf.TabIndex = 4;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = true;
            this.btn_mdf.Click += new System.EventHandler(this.btn_mdf_Click);
            // 
            // btn_ajt
            // 
            this.btn_ajt.AutoSize = true;
            this.btn_ajt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_ajt.Location = new System.Drawing.Point(512, 377);
            this.btn_ajt.Name = "btn_ajt";
            this.btn_ajt.Size = new System.Drawing.Size(302, 46);
            this.btn_ajt.TabIndex = 6;
            this.btn_ajt.Text = "Ajout de médicament";
            this.btn_ajt.UseVisualStyleBackColor = true;
            this.btn_ajt.Click += new System.EventHandler(this.btn_ajt_Click);
            // 
            // txt_med
            // 
            this.txt_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_med.Location = new System.Drawing.Point(501, 330);
            this.txt_med.Name = "txt_med";
            this.txt_med.Size = new System.Drawing.Size(330, 41);
            this.txt_med.TabIndex = 5;
            this.txt_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_med_KeyPress);
            // 
            // btn_spr
            // 
            this.btn_spr.AutoSize = true;
            this.btn_spr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_spr.Location = new System.Drawing.Point(474, 548);
            this.btn_spr.Name = "btn_spr";
            this.btn_spr.Size = new System.Drawing.Size(370, 46);
            this.btn_spr.TabIndex = 8;
            this.btn_spr.Text = "Supprimer un médicament";
            this.btn_spr.UseVisualStyleBackColor = true;
            this.btn_spr.Click += new System.EventHandler(this.btn_spr_Click);
            // 
            // lst_spr_med
            // 
            this.lst_spr_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_spr_med.FormattingEnabled = true;
            this.lst_spr_med.Location = new System.Drawing.Point(501, 498);
            this.lst_spr_med.Name = "lst_spr_med";
            this.lst_spr_med.Size = new System.Drawing.Size(330, 44);
            this.lst_spr_med.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(442, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Medicament :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(677, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nouvelle valeur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(455, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valeur du nouveau medicament :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(489, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medicament a supprimer :";
            // 
            // Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_spr);
            this.Controls.Add(this.lst_spr_med);
            this.Controls.Add(this.btn_ajt);
            this.Controls.Add(this.txt_med);
            this.Controls.Add(this.btn_mdf);
            this.Controls.Add(this.lst_mdf_med);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.txt_mdf_med);
            this.Controls.Add(this.grid_med);
            this.Name = "Medicaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicaments";
            ((System.ComponentModel.ISupportInitialize)(this.grid_med)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_med;
        private System.Windows.Forms.TextBox txt_mdf_med;
        private System.Windows.Forms.Button btn_link_acl;
        private System.Windows.Forms.ComboBox lst_mdf_med;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_ajt;
        private System.Windows.Forms.TextBox txt_med;
        private System.Windows.Forms.Button btn_spr;
        private System.Windows.Forms.ComboBox lst_spr_med;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

namespace PPE_C_Sharp_GUI
{
    partial class Eleves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.btn_link_acl = new System.Windows.Forms.Button();
            this.btn_link_elv = new System.Windows.Forms.Button();
            this.grid_elv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_elv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_srch
            // 
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(13, 668);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(981, 41);
            this.txt_srch.TabIndex = 1;
            // 
            // btn_link_acl
            // 
            this.btn_link_acl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_acl.Location = new System.Drawing.Point(850, 621);
            this.btn_link_acl.Name = "btn_link_acl";
            this.btn_link_acl.Size = new System.Drawing.Size(144, 41);
            this.btn_link_acl.TabIndex = 2;
            this.btn_link_acl.Text = "Retour";
            this.btn_link_acl.UseVisualStyleBackColor = true;
            this.btn_link_acl.Click += new System.EventHandler(this.btn_link_acl_Click);
            // 
            // btn_link_elv
            // 
            this.btn_link_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_elv.Location = new System.Drawing.Point(12, 621);
            this.btn_link_elv.Name = "btn_link_elv";
            this.btn_link_elv.Size = new System.Drawing.Size(234, 41);
            this.btn_link_elv.TabIndex = 3;
            this.btn_link_elv.Text = "Ajout d\'élève";
            this.btn_link_elv.UseVisualStyleBackColor = true;
            this.btn_link_elv.Click += new System.EventHandler(this.btn_link_elv_Click);
            // 
            // grid_elv
            // 
            this.grid_elv.AllowUserToAddRows = false;
            this.grid_elv.AllowUserToDeleteRows = false;
            this.grid_elv.AllowUserToResizeColumns = false;
            this.grid_elv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_elv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_elv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_elv.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_elv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_elv.Location = new System.Drawing.Point(13, 12);
            this.grid_elv.MultiSelect = false;
            this.grid_elv.Name = "grid_elv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_elv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_elv.RowHeadersVisible = false;
            this.grid_elv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_elv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_elv.RowTemplate.Height = 24;
            this.grid_elv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_elv.ShowCellErrors = false;
            this.grid_elv.ShowEditingIcon = false;
            this.grid_elv.ShowRowErrors = false;
            this.grid_elv.Size = new System.Drawing.Size(981, 588);
            this.grid_elv.TabIndex = 4;
            this.grid_elv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_elv_CellDoubleClick);
            // 
            // Eleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.grid_elv);
            this.Controls.Add(this.btn_link_elv);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.txt_srch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Eleves";
            this.Text = "Eleves";
            ((System.ComponentModel.ISupportInitialize)(this.grid_elv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button btn_link_acl;
        private System.Windows.Forms.Button btn_link_elv;
        private System.Windows.Forms.DataGridView grid_elv;
    }
}
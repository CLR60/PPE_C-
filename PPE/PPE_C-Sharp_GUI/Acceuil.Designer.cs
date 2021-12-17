
namespace PPE_C_Sharp_GUI
{
    partial class Acceuil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.btn_link_vst = new System.Windows.Forms.Button();
            this.btn_link_elv = new System.Windows.Forms.Button();
            this.btn_link_med = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_vst = new System.Windows.Forms.DataGridView();
            this.txt_search_placeholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vst)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_srch
            // 
            this.txt_srch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(12, 668);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(219, 41);
            this.txt_srch.TabIndex = 1;
            this.txt_srch.TextChanged += new System.EventHandler(this.txt_srch_TextChanged);
            this.txt_srch.Enter += new System.EventHandler(this.txt_srch_Enter);
            this.txt_srch.Leave += new System.EventHandler(this.txt_srch_Leave);
            // 
            // btn_link_vst
            // 
            this.btn_link_vst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_link_vst.AutoSize = true;
            this.btn_link_vst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_link_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_vst.Location = new System.Drawing.Point(237, 666);
            this.btn_link_vst.Name = "btn_link_vst";
            this.btn_link_vst.Size = new System.Drawing.Size(227, 46);
            this.btn_link_vst.TabIndex = 2;
            this.btn_link_vst.Text = "Ajout de visites";
            this.btn_link_vst.UseVisualStyleBackColor = true;
            this.btn_link_vst.Click += new System.EventHandler(this.btn_link_vst_Click);
            // 
            // btn_link_elv
            // 
            this.btn_link_elv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_link_elv.AutoSize = true;
            this.btn_link_elv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_link_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_elv.Location = new System.Drawing.Point(470, 666);
            this.btn_link_elv.Name = "btn_link_elv";
            this.btn_link_elv.Size = new System.Drawing.Size(99, 46);
            this.btn_link_elv.TabIndex = 3;
            this.btn_link_elv.Text = "Eleve";
            this.btn_link_elv.UseVisualStyleBackColor = true;
            this.btn_link_elv.Click += new System.EventHandler(this.btn_link_elv_Click);
            // 
            // btn_link_med
            // 
            this.btn_link_med.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_link_med.AutoSize = true;
            this.btn_link_med.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_link_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_med.Location = new System.Drawing.Point(575, 668);
            this.btn_link_med.Name = "btn_link_med";
            this.btn_link_med.Size = new System.Drawing.Size(185, 46);
            this.btn_link_med.TabIndex = 4;
            this.btn_link_med.Text = "Medicament";
            this.btn_link_med.UseVisualStyleBackColor = true;
            this.btn_link_med.Click += new System.EventHandler(this.btn_link_med_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(774, 668);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Pour modifier une visite, double cliquer sur sa ligne";
            // 
            // grid_vst
            // 
            this.grid_vst.AllowUserToAddRows = false;
            this.grid_vst.AllowUserToDeleteRows = false;
            this.grid_vst.AllowUserToResizeColumns = false;
            this.grid_vst.AllowUserToResizeRows = false;
            this.grid_vst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_vst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_vst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_vst.Location = new System.Drawing.Point(12, 12);
            this.grid_vst.MultiSelect = false;
            this.grid_vst.Name = "grid_vst";
            this.grid_vst.RowHeadersVisible = false;
            this.grid_vst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_vst.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_vst.RowTemplate.Height = 24;
            this.grid_vst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_vst.ShowCellErrors = false;
            this.grid_vst.ShowEditingIcon = false;
            this.grid_vst.ShowRowErrors = false;
            this.grid_vst.Size = new System.Drawing.Size(982, 648);
            this.grid_vst.TabIndex = 0;
            this.grid_vst.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_vst_CellDoubleClick);
            // 
            // txt_search_placeholder
            // 
            this.txt_search_placeholder.AutoSize = true;
            this.txt_search_placeholder.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search_placeholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_search_placeholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_search_placeholder.Location = new System.Drawing.Point(29, 671);
            this.txt_search_placeholder.Name = "txt_search_placeholder";
            this.txt_search_placeholder.Size = new System.Drawing.Size(175, 36);
            this.txt_search_placeholder.TabIndex = 7;
            this.txt_search_placeholder.Text = "Recherche :";
            this.txt_search_placeholder.Click += new System.EventHandler(this.txt_search_placeholder_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txt_search_placeholder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_link_med);
            this.Controls.Add(this.btn_link_elv);
            this.Controls.Add(this.btn_link_vst);
            this.Controls.Add(this.txt_srch);
            this.Controls.Add(this.grid_vst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)(this.grid_vst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button btn_link_vst;
        private System.Windows.Forms.Button btn_link_elv;
        private System.Windows.Forms.Button btn_link_med;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_vst;
        private System.Windows.Forms.Label txt_search_placeholder;
    }
}
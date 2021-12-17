
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_placeholder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_elv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_srch
            // 
            this.txt_srch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(140, 661);
            this.txt_srch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(255, 41);
            this.txt_srch.TabIndex = 3;
            this.txt_srch.TextChanged += new System.EventHandler(this.txt_srch_TextChanged);
            this.txt_srch.Enter += new System.EventHandler(this.txt_srch_Enter);
            this.txt_srch.Leave += new System.EventHandler(this.txt_srch_Leave);
            // 
            // btn_link_acl
            // 
            this.btn_link_acl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_link_acl.AutoSize = true;
            this.btn_link_acl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_link_acl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_acl.Location = new System.Drawing.Point(13, 659);
            this.btn_link_acl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_link_acl.Name = "btn_link_acl";
            this.btn_link_acl.Size = new System.Drawing.Size(115, 46);
            this.btn_link_acl.TabIndex = 5;
            this.btn_link_acl.Text = "Retour";
            this.btn_link_acl.UseVisualStyleBackColor = true;
            this.btn_link_acl.Click += new System.EventHandler(this.btn_link_acl_Click);
            // 
            // btn_link_elv
            // 
            this.btn_link_elv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_link_elv.AutoSize = true;
            this.btn_link_elv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_link_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_elv.Location = new System.Drawing.Point(407, 659);
            this.btn_link_elv.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_link_elv.Name = "btn_link_elv";
            this.btn_link_elv.Size = new System.Drawing.Size(196, 46);
            this.btn_link_elv.TabIndex = 4;
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
            this.grid_elv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_elv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_elv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_elv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_elv.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_elv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_elv.Location = new System.Drawing.Point(12, 9);
            this.grid_elv.Margin = new System.Windows.Forms.Padding(0);
            this.grid_elv.MultiSelect = false;
            this.grid_elv.Name = "grid_elv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
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
            this.grid_elv.Size = new System.Drawing.Size(982, 643);
            this.grid_elv.TabIndex = 1;
            this.grid_elv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_elv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(612, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Pour modifier un élève, double cliquer sur sa ligne";
            // 
            // txt_search_placeholder
            // 
            this.txt_search_placeholder.AutoSize = true;
            this.txt_search_placeholder.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search_placeholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_placeholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_search_placeholder.Location = new System.Drawing.Point(174, 664);
            this.txt_search_placeholder.Name = "txt_search_placeholder";
            this.txt_search_placeholder.Size = new System.Drawing.Size(175, 36);
            this.txt_search_placeholder.TabIndex = 6;
            this.txt_search_placeholder.Text = "Recherche :";
            this.txt_search_placeholder.Click += new System.EventHandler(this.txt_search_placeholder_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(745, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Pour rechercher par date utiliser le format : \"année\" / \"mois\" / \"jour\" ( les v" +
    "aleur peuvent être null tant que le / est présent )";
            // 
            // Eleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search_placeholder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_elv);
            this.Controls.Add(this.btn_link_elv);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.txt_srch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Eleves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_search_placeholder;
        private System.Windows.Forms.Label label2;
    }
}

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.btn_link_vst = new System.Windows.Forms.Button();
            this.btn_link_elv = new System.Windows.Forms.Button();
            this.btn_link_med = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 650);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_srch
            // 
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(12, 669);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(359, 41);
            this.txt_srch.TabIndex = 1;
            // 
            // btn_link_vst
            // 
            this.btn_link_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_vst.Location = new System.Drawing.Point(377, 669);
            this.btn_link_vst.Name = "btn_link_vst";
            this.btn_link_vst.Size = new System.Drawing.Size(238, 41);
            this.btn_link_vst.TabIndex = 2;
            this.btn_link_vst.Text = "Ajout de visites";
            this.btn_link_vst.UseVisualStyleBackColor = true;
            this.btn_link_vst.Click += new System.EventHandler(this.btn_link_vst_Click);
            // 
            // btn_link_elv
            // 
            this.btn_link_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_elv.Location = new System.Drawing.Point(621, 669);
            this.btn_link_elv.Name = "btn_link_elv";
            this.btn_link_elv.Size = new System.Drawing.Size(157, 41);
            this.btn_link_elv.TabIndex = 3;
            this.btn_link_elv.Text = "Eleve";
            this.btn_link_elv.UseVisualStyleBackColor = true;
            this.btn_link_elv.Click += new System.EventHandler(this.btn_link_elv_Click);
            // 
            // btn_link_med
            // 
            this.btn_link_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link_med.Location = new System.Drawing.Point(784, 669);
            this.btn_link_med.Name = "btn_link_med";
            this.btn_link_med.Size = new System.Drawing.Size(210, 41);
            this.btn_link_med.TabIndex = 4;
            this.btn_link_med.Text = "Medicament";
            this.btn_link_med.UseVisualStyleBackColor = true;
            this.btn_link_med.Click += new System.EventHandler(this.btn_link_med_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_link_med);
            this.Controls.Add(this.btn_link_elv);
            this.Controls.Add(this.btn_link_vst);
            this.Controls.Add(this.txt_srch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button btn_link_vst;
        private System.Windows.Forms.Button btn_link_elv;
        private System.Windows.Forms.Button btn_link_med;
    }
}
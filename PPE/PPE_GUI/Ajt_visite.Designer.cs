
namespace PPE_C_Sharp_GUI
{
    partial class Ajt_visite
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
            this.radio_msn = new System.Windows.Forms.RadioButton();
            this.radio_hpt = new System.Windows.Forms.RadioButton();
            this.radio_prt = new System.Windows.Forms.RadioButton();
            this.btn_link_acl = new System.Windows.Forms.Button();
            this.btn_vst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_msn
            // 
            this.radio_msn.AutoSize = true;
            this.radio_msn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radio_msn.Location = new System.Drawing.Point(26, 600);
            this.radio_msn.Name = "radio_msn";
            this.radio_msn.Size = new System.Drawing.Size(229, 40);
            this.radio_msn.TabIndex = 8;
            this.radio_msn.TabStop = true;
            this.radio_msn.Text = "Retour maison";
            this.radio_msn.UseVisualStyleBackColor = true;
            // 
            // radio_hpt
            // 
            this.radio_hpt.AutoSize = true;
            this.radio_hpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radio_hpt.Location = new System.Drawing.Point(420, 600);
            this.radio_hpt.Name = "radio_hpt";
            this.radio_hpt.Size = new System.Drawing.Size(129, 40);
            this.radio_hpt.TabIndex = 9;
            this.radio_hpt.TabStop = true;
            this.radio_hpt.Text = "Hôpital";
            this.radio_hpt.UseVisualStyleBackColor = true;
            // 
            // radio_prt
            // 
            this.radio_prt.AutoSize = true;
            this.radio_prt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radio_prt.Location = new System.Drawing.Point(685, 600);
            this.radio_prt.Name = "radio_prt";
            this.radio_prt.Size = new System.Drawing.Size(255, 40);
            this.radio_prt.TabIndex = 10;
            this.radio_prt.TabStop = true;
            this.radio_prt.Text = "Parent prévenue";
            this.radio_prt.UseVisualStyleBackColor = true;
            // 
            // btn_link_acl
            // 
            this.btn_link_acl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_acl.Location = new System.Drawing.Point(12, 668);
            this.btn_link_acl.Name = "btn_link_acl";
            this.btn_link_acl.Size = new System.Drawing.Size(144, 41);
            this.btn_link_acl.TabIndex = 13;
            this.btn_link_acl.Text = "Retour";
            this.btn_link_acl.UseVisualStyleBackColor = true;
            this.btn_link_acl.Click += new System.EventHandler(this.btn_link_acl_Click);
            // 
            // btn_vst
            // 
            this.btn_vst.AutoSize = true;
            this.btn_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_vst.Location = new System.Drawing.Point(384, 663);
            this.btn_vst.Name = "btn_vst";
            this.btn_vst.Size = new System.Drawing.Size(228, 46);
            this.btn_vst.TabIndex = 22;
            this.btn_vst.Text = "Ajouter la visite";
            this.btn_vst.UseVisualStyleBackColor = true;
            // 
            // Ajt_visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_vst);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.radio_prt);
            this.Controls.Add(this.radio_hpt);
            this.Controls.Add(this.radio_msn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajt_visite";
            this.Text = "Ajout de Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radio_msn;
        private System.Windows.Forms.RadioButton radio_hpt;
        private System.Windows.Forms.RadioButton radio_prt;
        private System.Windows.Forms.Button btn_link_acl;
        private System.Windows.Forms.Button btn_vst;
    }
}
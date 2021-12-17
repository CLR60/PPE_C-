
namespace PPE_C_Sharp_GUI
{
    partial class Quantity
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ccl = new System.Windows.Forms.Button();
            this.pan_med = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(329, 46);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajouter un medicament";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_send
            // 
            this.btn_send.AutoSize = true;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_send.Location = new System.Drawing.Point(414, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(362, 46);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Envoyer les medicaments";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantité / nouvelle quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supprimer";
            // 
            // btn_ccl
            // 
            this.btn_ccl.AutoSize = true;
            this.btn_ccl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ccl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_ccl.Location = new System.Drawing.Point(864, 12);
            this.btn_ccl.Name = "btn_ccl";
            this.btn_ccl.Size = new System.Drawing.Size(130, 46);
            this.btn_ccl.TabIndex = 5;
            this.btn_ccl.Text = "Annuler";
            this.btn_ccl.UseVisualStyleBackColor = true;
            this.btn_ccl.Click += new System.EventHandler(this.btn_ccl_Click);
            // 
            // pan_med
            // 
            this.pan_med.AutoScroll = true;
            this.pan_med.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pan_med.Location = new System.Drawing.Point(15, 81);
            this.pan_med.Name = "pan_med";
            this.pan_med.Size = new System.Drawing.Size(979, 628);
            this.pan_med.TabIndex = 6;
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.pan_med);
            this.Controls.Add(this.btn_ccl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_add);
            this.Name = "Quantity";
            this.Text = "Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ccl;
        private System.Windows.Forms.Panel pan_med;
    }
}
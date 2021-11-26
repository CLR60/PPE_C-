
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
            this.date_vst = new System.Windows.Forms.DateTimePicker();
            this.time_d_vst = new System.Windows.Forms.DateTimePicker();
            this.time_f_vst = new System.Windows.Forms.DateTimePicker();
            this.txt_mtf = new System.Windows.Forms.TextBox();
            this.txt_comm = new System.Windows.Forms.TextBox();
            this.lst_med = new System.Windows.Forms.ListBox();
            this.radio_msn = new System.Windows.Forms.RadioButton();
            this.radio_hpt = new System.Windows.Forms.RadioButton();
            this.radio_prt = new System.Windows.Forms.RadioButton();
            this.lst_elv = new System.Windows.Forms.ComboBox();
            this.lst_cls = new System.Windows.Forms.ComboBox();
            this.btn_link_acl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_vst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_vst
            // 
            this.date_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.date_vst.Location = new System.Drawing.Point(384, 143);
            this.date_vst.Name = "date_vst";
            this.date_vst.Size = new System.Drawing.Size(580, 41);
            this.date_vst.TabIndex = 0;
            this.date_vst.Value = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            // 
            // time_d_vst
            // 
            this.time_d_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.time_d_vst.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_d_vst.Location = new System.Drawing.Point(384, 189);
            this.time_d_vst.Name = "time_d_vst";
            this.time_d_vst.Size = new System.Drawing.Size(580, 41);
            this.time_d_vst.TabIndex = 1;
            this.time_d_vst.Value = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            // 
            // time_f_vst
            // 
            this.time_f_vst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.time_f_vst.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_f_vst.Location = new System.Drawing.Point(384, 237);
            this.time_f_vst.Name = "time_f_vst";
            this.time_f_vst.Size = new System.Drawing.Size(580, 41);
            this.time_f_vst.TabIndex = 2;
            this.time_f_vst.Value = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            // 
            // txt_mtf
            // 
            this.txt_mtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_mtf.Location = new System.Drawing.Point(384, 285);
            this.txt_mtf.Name = "txt_mtf";
            this.txt_mtf.Size = new System.Drawing.Size(580, 41);
            this.txt_mtf.TabIndex = 5;
            // 
            // txt_comm
            // 
            this.txt_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_comm.Location = new System.Drawing.Point(384, 334);
            this.txt_comm.Multiline = true;
            this.txt_comm.Name = "txt_comm";
            this.txt_comm.Size = new System.Drawing.Size(580, 88);
            this.txt_comm.TabIndex = 6;
            // 
            // lst_med
            // 
            this.lst_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_med.FormattingEnabled = true;
            this.lst_med.ItemHeight = 36;
            this.lst_med.Location = new System.Drawing.Point(384, 428);
            this.lst_med.Name = "lst_med";
            this.lst_med.Size = new System.Drawing.Size(580, 148);
            this.lst_med.TabIndex = 7;
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
            // lst_elv
            // 
            this.lst_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_elv.FormattingEnabled = true;
            this.lst_elv.Location = new System.Drawing.Point(384, 73);
            this.lst_elv.Name = "lst_elv";
            this.lst_elv.Size = new System.Drawing.Size(580, 44);
            this.lst_elv.TabIndex = 11;
            // 
            // lst_cls
            // 
            this.lst_cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_cls.FormattingEnabled = true;
            this.lst_cls.Location = new System.Drawing.Point(384, 14);
            this.lst_cls.Name = "lst_cls";
            this.lst_cls.Size = new System.Drawing.Size(580, 44);
            this.lst_cls.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Eleve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(20, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Heure de début";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Heure de fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(20, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 36);
            this.label6.TabIndex = 19;
            this.label6.Text = "Motif de la visite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(20, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 36);
            this.label7.TabIndex = 20;
            this.label7.Text = "Commentaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(20, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Médicament";
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_link_acl);
            this.Controls.Add(this.lst_cls);
            this.Controls.Add(this.lst_elv);
            this.Controls.Add(this.radio_prt);
            this.Controls.Add(this.radio_hpt);
            this.Controls.Add(this.radio_msn);
            this.Controls.Add(this.lst_med);
            this.Controls.Add(this.txt_comm);
            this.Controls.Add(this.txt_mtf);
            this.Controls.Add(this.time_f_vst);
            this.Controls.Add(this.time_d_vst);
            this.Controls.Add(this.date_vst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajt_visite";
            this.Text = "Ajout de Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_vst;
        private System.Windows.Forms.DateTimePicker time_d_vst;
        private System.Windows.Forms.DateTimePicker time_f_vst;
        private System.Windows.Forms.TextBox txt_mtf;
        private System.Windows.Forms.TextBox txt_comm;
        private System.Windows.Forms.ListBox lst_med;
        private System.Windows.Forms.RadioButton radio_msn;
        private System.Windows.Forms.RadioButton radio_hpt;
        private System.Windows.Forms.RadioButton radio_prt;
        private System.Windows.Forms.ComboBox lst_elv;
        private System.Windows.Forms.ComboBox lst_cls;
        private System.Windows.Forms.Button btn_link_acl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_vst;
    }
}
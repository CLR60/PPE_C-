
namespace PPE_C_Sharp_GUI
{
    partial class Mdf_eleve
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
            this.btn_spr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_link_elv = new System.Windows.Forms.Button();
            this.date_elv = new System.Windows.Forms.DateTimePicker();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.txt_nbr = new System.Windows.Forms.TextBox();
            this.lst_cls = new System.Windows.Forms.ComboBox();
            this.txt_prn = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_elv = new System.Windows.Forms.Button();
            this.txt_tel_prt = new System.Windows.Forms.TextBox();
            this.txt_tel_elv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_tier = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_spr
            // 
            this.btn_spr.AutoSize = true;
            this.btn_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_spr.Location = new System.Drawing.Point(722, 623);
            this.btn_spr.Name = "btn_spr";
            this.btn_spr.Size = new System.Drawing.Size(253, 46);
            this.btn_spr.TabIndex = 64;
            this.btn_spr.Text = "Supprimer l\'élève";
            this.btn_spr.UseVisualStyleBackColor = true;
            this.btn_spr.Click += new System.EventHandler(this.btn_spr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(31, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(31, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(31, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 36);
            this.label6.TabIndex = 52;
            this.label6.Text = "Commentaire santé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(31, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 36);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nombre de visite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(31, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 36);
            this.label9.TabIndex = 55;
            this.label9.Text = "Prénom de l\'élève";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(31, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 36);
            this.label8.TabIndex = 57;
            this.label8.Text = "Nom de l\'élève";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(31, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 59;
            this.label2.Text = "Telephone parent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(31, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 36);
            this.label4.TabIndex = 61;
            this.label4.Text = "Telephone élève";
            // 
            // btn_link_elv
            // 
            this.btn_link_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_link_elv.Location = new System.Drawing.Point(12, 668);
            this.btn_link_elv.Name = "btn_link_elv";
            this.btn_link_elv.Size = new System.Drawing.Size(144, 41);
            this.btn_link_elv.TabIndex = 62;
            this.btn_link_elv.Text = "Retour";
            this.btn_link_elv.UseVisualStyleBackColor = true;
            this.btn_link_elv.Click += new System.EventHandler(this.btn_link_elv_Click);
            // 
            // date_elv
            // 
            this.date_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.date_elv.Location = new System.Drawing.Point(395, 202);
            this.date_elv.Name = "date_elv";
            this.date_elv.Size = new System.Drawing.Size(580, 41);
            this.date_elv.TabIndex = 65;
            this.date_elv.Value = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            // 
            // txt_com
            // 
            this.txt_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_com.Location = new System.Drawing.Point(395, 251);
            this.txt_com.Multiline = true;
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(580, 84);
            this.txt_com.TabIndex = 66;
            // 
            // txt_nbr
            // 
            this.txt_nbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_nbr.Location = new System.Drawing.Point(395, 527);
            this.txt_nbr.Name = "txt_nbr";
            this.txt_nbr.ReadOnly = true;
            this.txt_nbr.Size = new System.Drawing.Size(580, 41);
            this.txt_nbr.TabIndex = 67;
            this.txt_nbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst_cls
            // 
            this.lst_cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lst_cls.FormattingEnabled = true;
            this.lst_cls.Location = new System.Drawing.Point(395, 148);
            this.lst_cls.Name = "lst_cls";
            this.lst_cls.Size = new System.Drawing.Size(580, 44);
            this.lst_cls.TabIndex = 68;
            // 
            // txt_prn
            // 
            this.txt_prn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_prn.Location = new System.Drawing.Point(395, 50);
            this.txt_prn.Name = "txt_prn";
            this.txt_prn.Size = new System.Drawing.Size(580, 41);
            this.txt_prn.TabIndex = 69;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_nom.Location = new System.Drawing.Point(395, 98);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(580, 41);
            this.txt_nom.TabIndex = 70;
            // 
            // btn_elv
            // 
            this.btn_elv.AutoSize = true;
            this.btn_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_elv.Location = new System.Drawing.Point(409, 623);
            this.btn_elv.Name = "btn_elv";
            this.btn_elv.Size = new System.Drawing.Size(260, 46);
            this.btn_elv.TabIndex = 71;
            this.btn_elv.Text = "Modifier un élève";
            this.btn_elv.UseVisualStyleBackColor = true;
            this.btn_elv.Click += new System.EventHandler(this.btn_elv_Click);
            // 
            // txt_tel_prt
            // 
            this.txt_tel_prt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_tel_prt.Location = new System.Drawing.Point(395, 351);
            this.txt_tel_prt.Name = "txt_tel_prt";
            this.txt_tel_prt.Size = new System.Drawing.Size(580, 41);
            this.txt_tel_prt.TabIndex = 72;
            // 
            // txt_tel_elv
            // 
            this.txt_tel_elv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_tel_elv.Location = new System.Drawing.Point(395, 404);
            this.txt_tel_elv.Name = "txt_tel_elv";
            this.txt_tel_elv.Size = new System.Drawing.Size(580, 41);
            this.txt_tel_elv.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(31, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 36);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tier Temps";
            // 
            // chk_tier
            // 
            this.chk_tier.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_tier.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_tier.Location = new System.Drawing.Point(395, 461);
            this.chk_tier.Name = "chk_tier";
            this.chk_tier.Size = new System.Drawing.Size(580, 41);
            this.chk_tier.TabIndex = 76;
            this.chk_tier.UseVisualStyleBackColor = true;
            // 
            // Mdf_eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.chk_tier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tel_elv);
            this.Controls.Add(this.txt_tel_prt);
            this.Controls.Add(this.btn_elv);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_prn);
            this.Controls.Add(this.lst_cls);
            this.Controls.Add(this.txt_nbr);
            this.Controls.Add(this.txt_com);
            this.Controls.Add(this.date_elv);
            this.Controls.Add(this.btn_spr);
            this.Controls.Add(this.btn_link_elv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Mdf_eleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mdf_eleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_spr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_link_elv;
        private System.Windows.Forms.DateTimePicker date_elv;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.TextBox txt_nbr;
        private System.Windows.Forms.ComboBox lst_cls;
        private System.Windows.Forms.TextBox txt_prn;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_elv;
        private System.Windows.Forms.TextBox txt_tel_prt;
        private System.Windows.Forms.TextBox txt_tel_elv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_tier;
    }
}
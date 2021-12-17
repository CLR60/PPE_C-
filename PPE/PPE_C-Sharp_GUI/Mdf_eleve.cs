using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PPE_C_Sharp_BO;
using PPE_C_Sharp_BLL;

namespace PPE_C_Sharp_GUI
{
    public partial class Mdf_eleve : Form
    {
        private Eleve eleve;
        public Mdf_eleve(Eleve eleve)
        {
            InitializeComponent();
            this.eleve = eleve;
            txt_nom.Text = eleve.Nom;
            txt_prn.Text = eleve.Prenom;
            txt_tel_elv.Text = eleve.Tel_elv;
            txt_tel_prt.Text = eleve.Tel_prt;
            txt_com.Text = eleve.Comentaire;
            List<Classe> classes = GestionEleves.GetClasses();
            lst_cls.DataSource = classes;
            var foundItem = classes.SingleOrDefault(item => item.Id == eleve.Classe.Id);
            lst_cls.SelectedItem = foundItem;
            date_elv.Value = eleve.Date_naissance;
            chk_tier.Checked = eleve.Tier_tps;
            int nbr = GestionEleves.GetNumberOfVisites(eleve.Id);
            txt_nbr.Text = nbr.ToString();
            if (nbr != 0)
            {
                btn_spr.Visible = false;
            }
        }

        private void btn_link_elv_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_elv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nom.Text) && !string.IsNullOrEmpty(txt_prn.Text) && !string.IsNullOrEmpty(txt_tel_elv.Text) && !string.IsNullOrEmpty(txt_tel_prt.Text) && !string.IsNullOrEmpty(txt_com.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment modifier cet élève ?", "Modifier", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Eleve eleve = new Eleve(this.eleve.Id, txt_nom.Text, txt_prn.Text, txt_tel_elv.Text, txt_tel_prt.Text, txt_com.Text, chk_tier.Checked, date_elv.Value, (Classe)lst_cls.SelectedItem);
                    GestionEleves.MdfEleve(eleve);
                    this.Close();
                    Thread th = new Thread(x => Application.Run(new Eleves()));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("Formulaire incomplet");
            }
        }

        private void btn_spr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élève ?","Supprimer", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                GestionEleves.DelEleve(this.eleve.Id);
                this.Close();
                Thread th = new Thread(x => Application.Run(new Eleves()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}

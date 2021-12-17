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
using PPE_C_Sharp_BLL;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_GUI
{
    public partial class Ajt_visite : Form
    {
        public Ajt_visite()
        {
            InitializeComponent();
            List<Classe> cls = GestionEleves.GetClassesWithEleves();
            lst_cls.DataSource = cls;
            refresh_eleve((Classe)lst_cls.SelectedItem);
            date_vst.Value = DateTime.Now;
            lst_med.DataSource = GestionMedicaments.GetMedicaments();
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Acceuil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_vst_Click(object sender, EventArgs e)
        {
            if(date_vst.Value > DateTime.Now)
            {
                MessageBox.Show("La date renseigner ne peut être superrieur a la date du jour", "Date");
            }
            else
            {
                if ((time_f_vst.Value.Subtract(time_d_vst.Value)) > new TimeSpan())
                {
                    if (!String.IsNullOrEmpty(txt_mtf.Text) && !String.IsNullOrEmpty(txt_comm.Text) && (radio_msn.Checked || radio_hpt.Checked))
                    {
                        ((List<Medicament>) lst_med.DataSource)[0].Quantity = Convert.ToInt32(txt_qtt.Text);
                        Visite v = new Visite(date_vst.Value, time_d_vst.Value.TimeOfDay, time_f_vst.Value.TimeOfDay, txt_mtf.Text, txt_comm.Text, radio_hpt.Checked, check_prt.Checked, (List<Medicament>)lst_med.DataSource, (Eleve)lst_elv.SelectedItem);
                        if (GestionVisite.InsVisite(v))
                        {
                            MessageBox.Show("Visite bien Insere", "Inserer");
                            btn_link_acl_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Un probleme est survenue", "Inserer");
                            btn_link_acl_Click(this, EventArgs.Empty);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formulaire incomplet");
                    }
                }
                else
                {
                    MessageBox.Show("L'heure de début ne peut être plus grande que l'heure de fin", "Heure");
                }
            }
        }
        public List<Eleve> refresh_eleve(Classe classe)
        {
            try
            {
                List<Eleve> liste = GestionEleves.GetElevesByClasse(classe);
                lst_elv.DataSource = liste;
                return liste;
            }
            catch (Exception e)
            {
                List<Eleve> liste = new List<Eleve>();
                return liste;
            }
        }

        private void lst_cls_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_eleve((Classe)lst_cls.SelectedItem);
        }

        private void lst_med_temp_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}

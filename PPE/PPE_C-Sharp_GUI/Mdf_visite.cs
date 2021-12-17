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
    public partial class Mdf_visite : Form
    {
        private List<Classe> classes;
        private List<Medicament> medicaments;
        private Visite visite_attr;
        
        public Mdf_visite(Visite visite)
        {
            InitializeComponent();
            visite_attr = visite;
            classes = GestionEleves.GetClassesWithEleves();
            lst_cls.DataSource = classes;
            var foundItem = classes.SingleOrDefault(item => item.Id == visite.Eleve.Classe.Id);
            lst_cls.SelectedItem = foundItem;
            List<Eleve> liste_eleve = refresh_eleve(foundItem);
            var foundItem2 = liste_eleve.SingleOrDefault(item => item.Id == visite.Eleve.Id);
            lst_elv.SelectedItem = foundItem2;
            date_vst.Value = visite.Date;
            DateTime dt = DateTime.Now;
            dt = dt.Date + visite.H_start;
            time_d_vst.Value = dt;
            dt = dt.Date + visite.H_end;
            time_f_vst.Value = dt;
            txt_mtf.Text = visite.Motif;
            txt_comm.Text = visite.Comm;
            medicaments = GestionMedicaments.GetMedicaments();
            lst_med.DataSource = medicaments;
            var foundItem3 = medicaments.SingleOrDefault(item => item.Id == visite.Medicaments[0].Id);
            lst_med.SelectedItem = foundItem3;
            txt_qtt.Text = visite.Medicaments[0].Quantity.ToString();
            
            if (visite.Suite)
            {
                radio_hpt.Checked = true;
            }
            else
            {
                radio_msn.Checked = true;
            }
            check_prt.Checked = visite.Parent;
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Acceuil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public List<Eleve> refresh_eleve(Classe classe)
        {
            List<Eleve> liste = GestionEleves.GetElevesByClasse(classe);
            lst_elv.DataSource = liste;
            return liste;
        }

        private void lst_cls_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_eleve((Classe)lst_cls.SelectedItem);
        }

        private void btn_qtt_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity((List<Medicament>)lst_med.DataSource);
            quantity.ShowDialog();
            lst_med.DataSource = quantity.liste_medicaments;
        }

        private void btn_vst_Click(object sender, EventArgs e)
        {
            if (date_vst.Value > DateTime.Now)
            {
                MessageBox.Show("La date renseigner ne peut être superrieur a la date du jour","Date");
            }
            else
            {
                if((time_f_vst.Value.Subtract(time_d_vst.Value)) > new TimeSpan())
                {
                    if(!String.IsNullOrEmpty(txt_mtf.Text) && !String.IsNullOrEmpty(txt_comm.Text))
                    {
                        if (!String.IsNullOrEmpty(txt_qtt.Text))
                        {
                            ((List<Medicament>) lst_med.DataSource)[0].Quantity = Convert.ToInt32(txt_qtt.Text);
                            Visite v = new Visite(visite_attr.Id,date_vst.Value,time_d_vst.Value.TimeOfDay,time_f_vst.Value.TimeOfDay,txt_mtf.Text,txt_comm.Text,radio_hpt.Checked,check_prt.Checked,(List<Medicament>)lst_med.DataSource,(Eleve)lst_elv.SelectedItem);
                            if (GestionVisite.MdfVisite(v))
                            {
                                MessageBox.Show("Visite bien modifier", "Modifier");
                                btn_link_acl_Click(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Un probleme est survenue", "Modifier");
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
                        MessageBox.Show("Formulaire incomplet");
                    }
                }
                else
                {
                    MessageBox.Show("L'heure de début ne peut être plus grande que l'heure de fin", "Heure");
                }
            }
        }

        private void btn_spr_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Etes vous sur de vouloir Supprimer cette visite ?", "Visite", MessageBoxButtons.YesNo);
            if ( DialogResult == DialogResult.Yes)
            {
                if (GestionVisite.DelVisite(visite_attr.Id))
                {
                    MessageBox.Show("Visite bien Supprimer", "Supprimer");
                    btn_link_acl_Click(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Un probleme est survenue", "Supprimer");
                    btn_link_acl_Click(this, EventArgs.Empty);
                }
            }
        }

        private void Mdf_visite_Load(object sender, EventArgs e)
        {
           
        }
    }
}

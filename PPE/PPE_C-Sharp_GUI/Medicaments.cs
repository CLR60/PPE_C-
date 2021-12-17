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
using System.Configuration;

namespace PPE_C_Sharp_GUI
{
    public partial class Medicaments : Form
    {
        public Medicaments()
        {
            InitializeComponent();
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]); // on definit la chaine de connection a la base de données (Voir App.config)
            refresh_data();
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Acceuil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_ajt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_med.Text))
            {
                MessageBox.Show("Champ non saisie");
            }
            else
            {
                GestionMedicaments.InsMedicament(new Medicament(txt_med.Text));
                refresh_data();
                txt_med.Text = "";
            }
        }

        private void btn_mdf_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mdf_med.Text))
            {
                MessageBox.Show("Champ non saisie");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier ce medicament ?", "Modifier", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Medicament medicament = (Medicament)lst_mdf_med.SelectedItem;
                    GestionMedicaments.MdfMedicament(new Medicament(medicament.Id, txt_mdf_med.Text)) ;
                    refresh_data();
                    txt_mdf_med.Text = "";
                }
            }
        }

        private void btn_spr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce medicament ?", "Supprimer", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Medicament medicament = (Medicament)lst_spr_med.SelectedItem;
                if (GestionMedicaments.DelMedicament(medicament.Id))
                {
                    MessageBox.Show("Medicament bien supprimer","Supprimer",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Medicament impossible a supprimer ! Il semble que ce médicament soit en lien avec une visite", "Supprimer", MessageBoxButtons.OK);
                }
                refresh_data();

            }
        }

        private void refresh_data()
        {
            List<Medicament> medicaments = GestionMedicaments.GetMedicaments();

            grid_med.DataSource = medicaments;

            grid_med.AutoResizeColumns();

            lst_mdf_med.DataSource = medicaments;
            lst_spr_med.DataSource = medicaments;

            int t;
            t = grid_med.Columns.IndexOf(grid_med.Columns["Id"]);
            grid_med.Columns[t].Visible = false;
            t = grid_med.Columns.IndexOf(grid_med.Columns["Quantity"]);
            grid_med.Columns[t].Visible = false;
        }

        private void txt_mdf_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // si touche presser est "ENTRER"
            {
                btn_mdf_Click(this, EventArgs.Empty);
            }
        }

        private void txt_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // si touche presser est "ENTRER"
            {
                btn_ajt_Click(this, EventArgs.Empty);
            }
        }
    }
}

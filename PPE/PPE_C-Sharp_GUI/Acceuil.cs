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
using System.Reflection;
using System.Configuration;

namespace PPE_C_Sharp_GUI
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();

            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]); // on definit la chaine de connection a la base de données (Voir App.config)

            grid_vst.AutoGenerateColumns = false;
                
            foreach(PropertyInfo prop in new Visite().GetType().GetProperties())
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = prop.Name;

                grid_vst.Columns.Add(Column);
            }

            var columnList = grid_vst.Columns.Cast<DataGridViewColumn>().ToList();
            int column_index = columnList.FindIndex(c => c.HeaderText.ToLower() == "suite");

            grid_vst.Columns[column_index].HeaderText = "Retour";
            grid_vst.Columns[0].Visible = false;

            refresh_data();
        }

        private void btn_link_vst_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Ajt_visite()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_link_elv_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_link_med_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Medicaments()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void grid_vst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                Visite v = GestionVisite.GetVisite(Int32.Parse(grid_vst.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()));
                this.Close(); // fermer la fenetre
                Thread th = new Thread(x => Application.Run(new Mdf_visite(v))); // preparer l'ouverture de la prochaine
                th.SetApartmentState(ApartmentState.STA);
                th.Start(); // ouvrir la prochaine
            }

        }

        private void txt_srch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_srch.Text))
            {
                refresh_data();
            }
            else
            {
                refresh_data(txt_srch.Text);
            }

            txt_srch_Enter(this, EventArgs.Empty);
        }

        public void refresh_data()
        {
            del_data();
            List<Visite> liste = GestionVisite.GetVisites();

            for (int i = 1; i <= liste.Count(); i++)
            {
                int j = i - 1;
                string retour;
                if (liste[j].Suite == true){
                    retour = "Hopital";
                }
                else
                {
                    if (liste[j].Suite == false)
                    {
                        retour = "Maison";
                    }
                    else
                    {
                        retour = "Classe";
                    }
                }
                grid_vst.Rows.Add(liste[j].Id, liste[j].Date.ToShortDateString(), liste[j].H_start, liste[j].H_end, liste[j].Motif, liste[j].Comm,retour, liste[j].Parent, String.Join(", ", liste[j].Medicaments), liste[j].Eleve);
            }

            grid_vst.AutoResizeColumns();
        }

        public void refresh_data(string str)
        {
            del_data();
            List<Visite> liste = GestionVisite.SortVisites(str);

            for (int i = 1; i <= liste.Count(); i++)
            {
                int j = i - 1;
                string retour;
                if (liste[j].Suite == true)
                {
                    retour = "Hopital";
                }
                else
                {
                    if (liste[j].Suite == false)
                    {
                        retour = "Maison";
                    }
                    else
                    {
                        retour = "Classe";
                    }
                }
                grid_vst.Rows.Add(liste[j].Id, liste[j].Date.ToShortDateString(), liste[j].H_start, liste[j].H_end, liste[j].Motif, liste[j].Comm, retour, liste[j].Parent, String.Join(", ", liste[j].Medicaments), liste[j].Eleve);
            }

            grid_vst.AutoResizeColumns();
        }

        public void del_data()
        {
            for (int i = 0;i < grid_vst.Rows.Count;i++)
            {
                grid_vst.Rows.RemoveAt(i);
            }
        }

        private void txt_srch_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_srch.Text))
            {
                txt_search_placeholder.Visible = true;
            }
            else
            {
                txt_search_placeholder.Visible = false;
            }
        }

        private void txt_search_placeholder_Click(object sender, EventArgs e)
        {
            txt_srch.Focus();
        }

        private void txt_srch_Leave(object sender, EventArgs e)
        {
            txt_srch_Enter(this, EventArgs.Empty);
        }
    }
}

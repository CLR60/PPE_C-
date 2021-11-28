using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PPE_C_Sharp_BLL;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_GUI
{
    public partial class Medicament : Form
    {
        private List<PPE_C_Sharp_BO.Medicament> medicamentsList;
        private PPE_C_Sharp_BO.Medicament selected;

        public Medicament()
        {
            InitializeComponent();
            reloadDataGridAndLst();
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Accueil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void btn_suppr(object sender, EventArgs e)
        {
            PPE_C_Sharp_BO.Medicament medicament = new PPE_C_Sharp_BO.Medicament(this.selected.Id, this.selected.Libelle);
            if (GestionMedicament.DelMedicament(medicament))
            {
                reloadDataGridAndLst();
            }
            
            
        }

        private void btn_ajt(object sender, EventArgs e)
        {
            PPE_C_Sharp_BO.Medicament medicament = new PPE_C_Sharp_BO.Medicament(txt_med.Text);
            GestionMedicament.InsMedicament(medicament);

            txt_med.Text = "";
            reloadDataGridAndLst();
        }

        private void btn_modif(object sender, EventArgs e)
        {
            PPE_C_Sharp_BO.Medicament medicament = new PPE_C_Sharp_BO.Medicament(this.selected.Id, this.selected.Libelle);
            GestionMedicament.MdfMedicament(medicament, txt_mdf_med.Text);
            txt_mdf_med.Text = "";
            
            reloadDataGridAndLst();
        }

        public void reloadDataGridAndLst()
        {
            grid_med.AutoGenerateColumns = false;

            foreach (PropertyInfo prop in new PPE_C_Sharp_BO.Medicament().GetType().GetProperties())
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();

                Column.DataPropertyName = prop.Name.ToLower();
                Column.HeaderText = prop.Name;

                grid_med.Columns.Add(Column);
            }

            List<PPE_C_Sharp_BO.Medicament> liste = new List<PPE_C_Sharp_BO.Medicament>();
            liste = GestionMedicament.GetMedicaments();

            grid_med.DataSource = liste;
            lst_mdf_med.DataSource = liste;
            lst_spr_med.DataSource = liste;

            this.medicamentsList = liste;
            this.selected = this.medicamentsList[0];
        }

        private void grid_med_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.selected = this.medicamentsList.SingleOrDefault(item => 
                    item.Id == Int32.Parse(grid_med.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()));
            }
            catch { }

            lst_mdf_med.SelectedItem = this.selected;
            lst_spr_med.SelectedItem = this.selected;
        }

    }
}

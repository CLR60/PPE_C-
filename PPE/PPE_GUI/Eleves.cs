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
using System.Configuration;
using System.Reflection;

namespace PPE_C_Sharp_GUI
{
    public partial class Eleves : Form
    {
        public Eleves()
        {
            InitializeComponent();
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]);

            grid_elv.AutoGenerateColumns = false;

            foreach (PropertyInfo prop in new Eleve().GetType().GetProperties())
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();

                Column.DataPropertyName = prop.Name.ToLower();
                Column.HeaderText = prop.Name;

                grid_elv.Columns.Add(Column);
            }

            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.GetEleves();

            grid_elv.DataSource = liste;


            // IMPORTANT ! PERMET LE COMPTE D'ATTRIBUT 
            //Type type = typeof(Eleve);
            //int NumberOfRecords = type.GetProperties().Length;

            //txt_srch.Text = " " + NumberOfRecords;

        }

        private void btn_link_elv_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Ajt_eleve()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Accueil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void grid_elv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(e.RowIndex.ToString());
            int id = Int32.Parse(grid_elv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            string nom = grid_elv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(), prenom = grid_elv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), tel_elv = grid_elv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), tel_prt = grid_elv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(), comentaire = grid_elv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            DateTime date_naissance = DateTime.Parse(grid_elv.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
            bool tier_tps = false; 
            if (grid_elv.Rows[e.RowIndex].Cells[7].FormattedValue.ToString().ToLower() == "true")
            {
                tier_tps = true;
            }
            Classe classe = GestionEleves.GetClasse(grid_elv.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());

            //Classe classe = 


            //MessageBox.Show(grid_elv.Rows[e.RowIndex].Cells[8].FormattedValue.GetType().Name);

            Eleve eleve = new Eleve(id,nom, prenom, tel_elv, tel_prt, comentaire, tier_tps, date_naissance, classe);


            //MessageBox.Show(eleve.Nom);
            //MessageBox.Show(eleve.Tier_tps.ToString());

            //Mdf_eleve mdf_Eleve = new Mdf_eleve(eleve);
            //mdf_Eleve.ShowDialog();

            this.Close();
            Thread th = new Thread(x => Application.Run(new Mdf_eleve(eleve)));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

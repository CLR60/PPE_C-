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

        private List<Eleve> liste = new List<Eleve>();
        public Eleves()
        {
            InitializeComponent(); // initialisation des composant graphique du formulaire

            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]); // on definit la chaine de connection a la base de données (Voir App.config)

            grid_elv.AutoGenerateColumns = false; // on desactive la generation automatique des colonne du datagrid pour les creer soit meme

            foreach (PropertyInfo prop in new Eleve().GetType().GetProperties()) // pour chaque attribut de Eleve
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn(); // creation d'une nouvelle colonne

                Column.HeaderText = prop.Name; // definit le nom de la colonne par le nom de la propriete de l'eleve
                Column.DataPropertyName = prop.Name.ToLower(); // definit la propriete a utiliser par le nom de la propriete Eleve

                grid_elv.Columns.Add(Column); // ajout de la colonne a notre datagrid
            }

             // creation d'une nouvelle liste de classe

            refresh_data();


            // IMPORTANT ! PERMET LE COMPTE D'ATTRIBUT 
            //Type type = typeof(Eleve);
            //int NumberOfRecords = type.GetProperties().Length;
            //     Aide a deboguer et voir les differents oublis

            //MessageBox.Show(grid_elv.Size.Width.ToString());

        }

        private void btn_link_elv_Click(object sender, EventArgs e) //quand btn_link_eleve (Ajout eleve) est cliquer
        {
            this.Close(); // fermer la fenetre
            Thread th = new Thread(x => Application.Run(new Ajt_eleve())); // preparer l'ouverture de la prochaine
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); // ouvrir la prochaine
        }

        private void btn_link_acl_Click(object sender, EventArgs e) //quand btn_link_acl (Retour) est cliquer
        {
            this.Close(); // fermer la fenetre
            Thread th = new Thread(x => Application.Run(new Acceuil())); // preparer l'ouverture de la prochaine
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); // ouvrir la prochaine
        }

        private void grid_elv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //quand une cellule de la datagrid est double cliquer
        {

            /*

                        int id = Int32.Parse(grid_elv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()); //recuperation des données
                        string nom = grid_elv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(), prenom = grid_elv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), tel_elv = grid_elv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), tel_prt = grid_elv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(), comentaire = grid_elv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                        DateTime date_naissance = DateTime.Parse(grid_elv.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                        bool tier_tps = false; 
                        if (grid_elv.Rows[e.RowIndex].Cells[7].FormattedValue.ToString().ToLower() == "true")
                        {
                            tier_tps = true;
                        }
                        Classe classe = GestionEleves.GetClasse(grid_elv.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
            
                        Eleve eleve = new Eleve(id,nom, prenom, tel_elv, tel_prt, comentaire, tier_tps, date_naissance, classe); // creation d'un nouvelle eleve avec ces données


            */
            if(e.RowIndex != -1)
            {
            Eleve eleve = GestionEleves.GetEleve(Int32.Parse(grid_elv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()));
             
            this.Close(); // fermer la fenetre
            Thread th = new Thread(x => Application.Run(new Mdf_eleve(eleve))); // preparer l'ouverture de la prochaine avec en parametre l'eleve
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
            liste = GestionEleves.GetEleves(); // recuperation de la liste de classe

            grid_elv.DataSource = liste; // don de donnée de la liste de classe a la datagrid

            grid_elv.Columns[0].Visible = false;

            grid_elv.Font = new Font("Roboto", 10);

            grid_elv.AutoResizeColumns();
        }

        public void refresh_data(string str)
        {
            liste = GestionEleves.SortEleves(str); // recuperation de la liste de classe

            grid_elv.DataSource = liste; // don de donnée de la liste de classe a la datagrid

            grid_elv.Columns[0].Visible = false;

            grid_elv.Font = new Font("Roboto", 10);

            grid_elv.AutoResizeColumns();
        }

        private void txt_srch_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_srch.Text)){
                txt_search_placeholder.Visible = true;
            }
            else
            {
                txt_search_placeholder.Visible = false;
            }
        }

        private void txt_srch_Leave(object sender, EventArgs e)
        {
            txt_srch_Enter(this, EventArgs.Empty);
        }

        private void txt_search_placeholder_Click(object sender, EventArgs e)
        {
            txt_srch.Focus();
        }
    }
}

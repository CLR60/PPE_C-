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
using System.Configuration;

namespace PPE_C_Sharp_GUI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]);
        }

        private void btn_cnx_Click(object sender, EventArgs e)
        {
            string login = txt_id.Text;
            string mdp = txt_mdp.Text;

            if (GestionEleves.Authentificate(login, mdp))
            {
                //MessageBox.Show("Fonctionne");
                this.Close();
                Thread th = new Thread(x => Application.Run(new Acceuil()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Login ou Mot de passe invalide !");
            }
        }

        private void btn_cnx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                //MessageBox.Show("enteer");
                btn_cnx_Click(this, EventArgs.Empty);
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                //MessageBox.Show("enteer");
                btn_cnx_Click(this, EventArgs.Empty);
            }
        }

        private void txt_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //MessageBox.Show("enteer");
                btn_cnx_Click(this, EventArgs.Empty);
            }
        }
    }
}

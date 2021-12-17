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
            InitializeComponent(); // initialisation des composant graphique du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PPE_C_Sharp_GUI.Properties.Settings.gestVisiteConnectionString"]); // on definit la chaine de connection a la base de données (Voir App.config)
            txt_mdp.UseSystemPasswordChar = true;
        }

        private void btn_cnx_Click(object sender, EventArgs e) // quand le bouton btn_clx (Connexion) est cliquer
        {
            string login = txt_id.Text; // recuperation des valeur des champs
            string mdp = txt_mdp.Text; // dans des variables

            if (GestionEleves.Authentificate(login, mdp)) //  on met en parametre le login et le mot de passe
            {                                             // si le retour est possitif alors
                this.Close();                             // on ferme la fenetre
                Thread th = new Thread(x => Application.Run(new Acceuil())); // on prepare une autre fenetre
                th.SetApartmentState(ApartmentState.STA); 
                th.Start(); // on ouvre cette fenetre
            }
            else // sinon
            {
                MessageBox.Show("Login ou Mot de passe invalide !"); // message d'erreur
            }
        }

        private void btn_cnx_KeyPress(object sender, KeyPressEventArgs e) // quand btn_cnx ( Connexion ) touche presser
        {
            if(e.KeyChar == (char)13) // si touche presser est "ENTRER"
            {
                btn_cnx_Click(this, EventArgs.Empty); // declencher l'evenement du clique sur le bouton
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e) // quand txt_id ( Zone d'idantifiant ) touche presser
        {
            if(e.KeyChar == (char)13) // si touche presser est "ENTRER"
            { 
                btn_cnx_Click(this, EventArgs.Empty); // declencher l'evenement du clique sur le bouton
            }
        }

        private void txt_mdp_KeyPress(object sender, KeyPressEventArgs e) // quand txt_mdp ( Zone du mot de passe ) touche presser
        {
            if (e.KeyChar == (char)13) // si touche presser est "ENTRER"
            {
                btn_cnx_Click(this, EventArgs.Empty); // declencher l'evenement du clique sur le bouton
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_mdp.UseSystemPasswordChar == true)
            {
                txt_mdp.UseSystemPasswordChar = false;
                btn_show.Image = PPE_C_Sharp_GUI.Properties.Resources.eye;
            }
            else
            {
                txt_mdp.UseSystemPasswordChar = true;
                btn_show.Image = PPE_C_Sharp_GUI.Properties.Resources.eye_slash;

            }
        }
    }
}

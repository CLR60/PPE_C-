using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using ppeBO; // Référence la couche BO
using ppeBLL; // Référence la couche BLL

namespace ppeGUI
{
    public partial class AuthentificationForm : Form
    {
        public AuthentificationForm()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void test(object sender, EventArgs e)
        {
            MessageBox.Show("Merci !", this.MdpText.Text);
        }
    }
}
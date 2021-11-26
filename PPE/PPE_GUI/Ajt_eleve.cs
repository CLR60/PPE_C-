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
    public partial class Ajt_eleve : Form
    {
        public Ajt_eleve()
        {
            InitializeComponent();
            List<Classe> classes = GestionEleves.GetClasses();
            lst_cls.DataSource = classes;
        }

        private void btn_link_elv_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_elv_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve(txt_nom.Text, txt_prn.Text, txt_tel_elv.Text, txt_tel_prt.Text, txt_com.Text, chk_tier.Checked, date_elv.Value, new Classe(((Classe)lst_cls.SelectedItem).Id, ((Classe)lst_cls.SelectedItem).Libelle));
            GestionEleves.InsEleve(eleve);
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

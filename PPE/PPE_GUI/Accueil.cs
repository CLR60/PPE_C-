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

namespace PPE_C_Sharp_GUI
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
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
            Thread th = new Thread(x => Application.Run(new Medicament()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

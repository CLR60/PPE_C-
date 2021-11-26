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
    public partial class Medicament : Form
    {
        public Medicament()
        {
            InitializeComponent();
        }

        private void btn_link_acl_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(x => Application.Run(new Acceuil()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

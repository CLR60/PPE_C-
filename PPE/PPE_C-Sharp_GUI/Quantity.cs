using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE_C_Sharp_BLL;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_GUI
{
    public partial class Quantity : Form
    {
        public List<Medicament> liste_medicaments;
        public Quantity(List<Medicament> medicaments)
        {
            InitializeComponent();
            liste_medicaments = medicaments;
            
            foreach(Medicament med in liste_medicaments)
            {
                create_med(med);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            create_med();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            liste_medicaments = new List<Medicament>();
            foreach (ListBox lb in pan_med.Controls.OfType<ListBox>())
            {
                int i = pan_med.Controls.IndexOf(lb);
                int nbr = (i / 3) + 1;
                /*int q = 0;*/
                /*if(((ComboBox)pan_med.Controls[i + 1]).SelectedIndex > -1)
                {
                     q = (int)((ComboBox)pan_med.Controls[i + 1]).SelectedItem;
                }
                else
                {
                    string reg = @"^\d+$";
                    string str = ((ComboBox)pan_med.Controls[i + 1]).Text;
                    Match m = Regex.Match(str,reg);
                    if (m.Success)
                    {
                        q = Int32.Parse(str);
                    }
                    else
                    {
                        MessageBox.Show("Il semble que la quantité du medicament " + nbr  + " est été mal saisie, la valeur na donc pas été enregistrer","Erreur");
                    }
                }*/

                int q = (int)((NumericUpDown)pan_med.Controls[i + 1]).Value;

                if (liste_medicaments.Any(item => item.Id == ((Medicament)lb.SelectedItem).Id))
                {
                    int index = liste_medicaments.FindIndex(item => item.Id == ((Medicament)lb.SelectedItem).Id);
                    liste_medicaments[index].Quantity = liste_medicaments[index].Quantity + q;
                }
                else
                {
                    if (q > 0)
                    {
                        liste_medicaments.Add(new Medicament(((Medicament)lb.SelectedItem).Id, ((Medicament)lb.SelectedItem).Libelle,q));
                    }
                }
                
            }
            this.Close();
        }

        private void create_med()
        {
            ListBox lbo = new ListBox();
            NumericUpDown cbo = new NumericUpDown();

            Button del = new Button();

            del.Text = "-";
            del.AutoSize = true;
            del.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            List<Medicament> med = GestionMedicaments.GetMedicaments();

            /*List<int> lst_int = new List<int>();
            for (int i = 0; i <= 15; i++)
            {
                lst_int.Add(i);
            }
            cbo.DataSource = lst_int;*/

            lbo.DataSource = med;
            lbo.Left = 0;
            cbo.Left = 140;
            del.Left = 290;
            int top = 0;
            if (pan_med.Controls.OfType<ListBox>().Count() > 0)
            {
                top =pan_med.Controls.OfType<ListBox>().Last().Top + 30;
            }
            lbo.Top = top;
            lbo.Height = cbo.Height;
            cbo.Top = top;
            del.Top = top;
            pan_med.Controls.Add(lbo);
            pan_med.Controls.Add(cbo);
            pan_med.Controls.Add(del);

            del_envent(del);
        }

        private void create_med(Medicament medicament)
        {
            ListBox lbo = new ListBox();
            NumericUpDown cbo = new NumericUpDown();

            Button del = new Button();

            del.Text = "-";
            del.AutoSize = true;
            del.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            List<Medicament> med = new List<Medicament>();
            med.Add(medicament);
            /*List<int> lst_int = new List<int>();
            for (int i = 0; i <= 15; i++)
            {
                lst_int.Add(i);
            }*/
            /*cbo.DataSource = lst_int;*/
            cbo.Value = medicament.Quantity;
            /*cbo.Text = medicament.Quantity.ToString();*/
            /*cbo.SelectedIndex = medicament.Quantity;*/
            /*var found = lst_int.SingleOrDefault(item => item == medicament.Quantity);
            cbo.SelectedItem = found;*/
            lbo.DataSource = med;

            lbo.Left = 0;
            cbo.Left = 140;
            del.Left = 290;
            int top = 0;
            if (pan_med.Controls.OfType<ListBox>().Count() > 0)
            {
                top = pan_med.Controls.OfType<ListBox>().Last().Top + 30;
            }
            lbo.Top = top;
            lbo.Height = cbo.Height;
            cbo.Top = top;
            del.Top = top;
            pan_med.Controls.Add(lbo);
            pan_med.Controls.Add(cbo);
            pan_med.Controls.Add(del);

            del_envent(del);
        }

        private void btn_ccl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_envent(Button btn)
        {
            btn.Click += (s, ev) =>
            {
                int i = pan_med.Controls.IndexOf(btn);
                DialogResult d = MessageBox.Show("Voulez vous vraiment supprimer ce medicament ?", "Supprimer", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    for(int j = i; j < pan_med.Controls.Count; j++)
                    {
                        pan_med.Controls[j].Top -= 30;
                    }
                    pan_med.Controls.RemoveAt(i);
                    pan_med.Controls.RemoveAt(i - 1);
                    pan_med.Controls.RemoveAt(i - 2);
                }
            };
        }
    }
}

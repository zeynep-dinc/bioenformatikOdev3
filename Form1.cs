using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bioenformatikOdev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxsekans;
            int u = 0;
            int bu = textBox1.TextLength;
            int iu = textBox2.TextLength;
            char[] birincisekans = new char[bu];
            char[] ikincisekans = new char[iu];
            string duz = " ";
            do
            {
                for (int i = 0; i < bu; i++)
                {
                    birincisekans[i] = textBox1.Text[i];
                    duz = duz + birincisekans[i] + "    ";
                }
                textBox3.Text = duz;
                duz = " ";
                u++;
            } while (u == 1);


            for (int i = 0; i < iu; i++)
            {
                ikincisekans[i] = textBox2.Text[i];
                listBox2.Items.Add("\n" + ikincisekans[i]);

            }

            int match = 0;

            for (int i = 0; i < iu; i++)

                for (int j = 0; j < bu; j++)
                {
                    {
                        if (ikincisekans[i] == birincisekans[j])
                        {

                            listBox3.Items.Add(ikincisekans[i].ToString() + birincisekans[j].ToString() + "MATCH");
                            match++;

                        }
                        else

                            listBox3.Items.Add(ikincisekans[i].ToString() + birincisekans[j].ToString() + "MISTAKE");
                      
                    }

                    if (bu > iu) maxsekans = bu;
                    else maxsekans = iu;
                    double a = Math.Ceiling((double)match / 2);
                    double intentity = (a / maxsekans);
                    label4.Text = Convert.ToString(Math.Round(intentity,3));



                }
        }
    }
}

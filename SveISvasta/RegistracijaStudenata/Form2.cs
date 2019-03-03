using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RegistracijaStudenata
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            BindingSource b = new BindingSource();
            b.DataSource = Program.spisakSkola;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if ((textBox1.Text).Equals("") || (textBox2.Text).Equals("") || (textBox3.Text).Equals(""))
            {
                MessageBox.Show(" Morate popuniti sva polja!", "Error");
            }

            else
            {
                Skola temp = new Skola(textBox1.Text, textBox2.Text, textBox3.Text);

                Program.spisakSkola.Add(temp);

                BindingSource b = new BindingSource();
                b.DataSource = Program.spisakSkola;
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text).Equals("") || (textBox2.Text).Equals("") || (textBox3.Text).Equals(""))
            {
                MessageBox.Show(" Morate popuniti sva polja!", "Error");
            }

            else
            {
                Skola temp = new Skola(textBox1.Text, textBox2.Text, textBox3.Text);

                Program.spisakSkola.Add(temp);

                BindingSource b = new BindingSource();
                b.DataSource = Program.spisakSkola;
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";

                Registracija newForm = new Registracija();
                newForm.Show();
                this.Hide();
            }
        }
    }
}

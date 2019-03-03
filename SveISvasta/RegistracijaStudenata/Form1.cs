using System;
using System.Windows.Forms;

namespace RegistracijaStudenata
{
    public partial class Registracija : Form
    {

        public Registracija()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dateTimePicker1.Value = datum;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text).Equals("") || (textBox2.Text).Equals("") || (textBox4.Text).Equals(""))
            {
                MessageBox.Show(" Morate popuniti sva polja!", "Error");
            }
            else
            {
                Ucenik temp = new Ucenik(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("MM/dd/yyyy"), textBox4.Text);

                Program.spisakUcenika.Add(temp);

                BindingSource c = new BindingSource();
                c.DataSource = Program.spisakSkola;

                BindingSource a = new BindingSource();
                a.DataSource = Program.spisakUcenika;

                dataGridView1.DataSource = a;
                dataGridView2.DataSource = c;

                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();

            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Program.spisakSkola;
            comboBox1.DataSource = bs;
            comboBox1.DisplayMember = "ImeSkole";
            comboBox1.ValueMember = "ImeSkole";
        }
    }
}

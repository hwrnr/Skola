using System;
using System.Windows.Forms;
namespace Zadatak1
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeLabel.AutoSize = true;
            //this.imeLabel.Font = new System.Drawing.Font(3, 147);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Text = "Ime: ";
            this.imeLabel.Size = new System.Drawing.Size(33, 13);
            this.imeLabel.Location = new System.Drawing.Point(3, 147);

            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox.Location = new System.Drawing.Point(33, 13);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(59, 13);
            this.imeTextBox.TabIndex = 1;
            this.imeTextBox.Text = "";

            this.prezimeLabel = new System.Windows.Forms.Label();
            this.prezimeLabel.AutoSize = true;
            //this.prezimeLabel.Font = new System.Drawing.Font(3, 147);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Text = "prezime: 0";
            this.prezimeLabel.Size = new System.Drawing.Size(33, 13);
            this.prezimeLabel.Location = new System.Drawing.Point(3, 147);

            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox.Location = new System.Drawing.Point(33, 13);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(59, 13);
            this.prezimeTextBox.TabIndex = 1;
            this.prezimeTextBox.Text = "";
        }
        /*public DodajSkolu()
        {
            InitializeComponent();
            //MessageBox.Show("Greska");
            //this.Show();
        }*/
        //private void DodajSkolu_Load() { }

        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox prezimeTextBox;
    }
}

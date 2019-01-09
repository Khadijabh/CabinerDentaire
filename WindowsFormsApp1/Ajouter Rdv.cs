using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Ajouter_Rdv : Form
	{
		public Ajouter_Rdv()
		{
			InitializeComponent();
		}

		private void Ajouter_Rdv_Load(object sender, EventArgs e)
		{
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            new Patient().load();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Equals(textBox2.Text))
                {
                    item.atjouerRDV(textBox2.Text, dateTimePicker1.Value, textBox5.Text);
                }
            }
			//Patient..atjouerRDV
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.NomP);
                }
            }
            if (textBox1.Text=="")
            {
                listBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP == listBox1.SelectedItem.ToString())
                {
                    textBox2.Enabled = false;
                    textBox2.Text = item.NomP;
                    textBox3.Enabled = false;
                    textBox3.Text = item.PrenomP;
                    textBox4.Enabled = false;
                    textBox4.Text = item.NumTel;
                }
            }
        }

        private void Ajouter_Rdv_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
        }
    }
}

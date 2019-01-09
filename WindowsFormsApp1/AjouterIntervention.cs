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
    public partial class AjouterIntervention : Form
    {
        public AjouterIntervention()
        {
            InitializeComponent();
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
            if (textBox1.Text == "")
            {
                listBox1.Visible = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP==listBox1.SelectedItem.ToString())
                {
                    textBox4.Enabled = false;
                    textBox4.Text = item.NomP;
                    textBox5.Enabled = false;
                    textBox5.Text = item.PrenomP;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(textBox4.Text))
                {
                    item.ajouterIntervention(new Intervention(float.Parse(textBox2.Text), textBox3.Text));
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // Permetter d'utiliser . décimale
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }

        private void AjouterIntervention_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            new Patient().load();
        }

        private void AjouterIntervention_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
        }
    }
}

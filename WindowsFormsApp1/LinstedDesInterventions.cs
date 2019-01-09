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
    public partial class LinstedDesInterventions : Form
    {
        public LinstedDesInterventions()
        {
            InitializeComponent();
        }

        private void LinstedDesInterventions_Load(object sender, EventArgs e)
        {
            new Patient().load();
            dataGridView1.Rows.Clear();
        }

        private void LinstedDesInterventions_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP == listBox1.SelectedItem.ToString())
                {
                    textBox2.Enabled = false;
                    textBox2.Text = item.NomP;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(textBox2.Text))
                {
                    foreach (var itm in item.Interventions)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = itm.Prix;
                        dataGridView1.Rows[n].Cells[1].Value = itm.Description;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.NomP);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(textBox2.Text))
                {
                    foreach (var itm in item.Interventions)
                    {
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = itm.Prix;
                            dataGridView1.Rows[n].Cells[1].Value = itm.Description;
                    }
                }
            }
        }
    }
}

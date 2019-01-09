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
    public partial class Payement : Form
    {
        public Payement()
        {
            InitializeComponent();
        }

        private void Payement_Load(object sender, EventArgs e)
        {
            new Patient().load();
        }

        private void Payement_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Patient.patients)
            {
                if (item.NomP == listBox1.SelectedItem.ToString())
                {
                    textBox2.Text = item.NomP;
                    textBox3.Text = item.PrenomP;
                    foreach (var interv in item.Interventions)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = interv.Prix;
                        dataGridView1.Rows[n].Cells[1].Value = interv.Etat;
                        dataGridView1.Rows[n].Cells[2].Value = interv.Description;
                        dataGridView1.Rows[n].Cells[3].Value = interv.RestePayement;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
            }

            foreach (var item in Patient.patients)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBox6.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    }
                }
            }
            textBox5.Text = (float.Parse(textBox4.Text) - float.Parse(textBox6.Text)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Patient().payement(dataGridView1.CurrentRow.Index,textBox2.Text.ToString(),float.Parse(numericUpDown1.Value.ToString()));
            dataGridView1.Rows.Clear();
            foreach (var item in Patient.patients)
            {
                if (item.NomP == listBox1.SelectedItem.ToString())
                {
                    textBox2.Text = item.NomP;
                    textBox3.Text = item.PrenomP;
                    foreach (var interv in item.Interventions)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = interv.Prix;
                        dataGridView1.Rows[n].Cells[1].Value = interv.Etat;
                        dataGridView1.Rows[n].Cells[2].Value = interv.Description;
                        dataGridView1.Rows[n].Cells[3].Value = interv.RestePayement;
                    }
                }
            }
        }
    }
}

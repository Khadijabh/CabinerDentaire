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

namespace WindowsFormsApp1
{
	public partial class ajouterPati : Form
	{
        Patient p = new Patient();
        string path,path2;
		public ajouterPati()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            String s = "";
            if (radioButton1.Checked) s = "Homme";
            else if (radioButton2.Checked) s = "Femme";
            Patient.ajouterPatient(new Patient(textBox1.Text, textBox2.Text, textBox7.Text, comboBox1.SelectedText, textBox3.Text, textBox3.Text, s, dateTimePicker1.Value.Date,path,path2));
            new Patient().Save();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
        }

        private void ajouterPati_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) radioButton1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) radioButton2.Checked = false;
        }

        private void ajouterPati_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            pictureBox1.ImageLocation = path;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path2 = openFileDialog1.FileName;
            pictureBox2.ImageLocation = path2;
        }
    }
}

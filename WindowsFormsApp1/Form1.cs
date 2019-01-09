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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MDIParent1 m = new MDIParent1();
            if (textBox1.Text == "medecin" && textBox2.Text == "0123")
            {
                m.Testi = 1;
                m.Show();
                this.Hide();
            }
            else if (textBox1.Text == "secretaire" && textBox2.Text == "123456")
            {
                m.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Identifiant ou mot de passe incorrecte");
		}
	}
}

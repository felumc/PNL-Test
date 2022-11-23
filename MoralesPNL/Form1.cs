using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoralesPNL
{
    public partial class Form1 : Form
    {
        public static string Nom;
        public static string FeNa;
        public static string Mail;
        public static string Tel;
        public static string Fe;
        public static string Ho;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nom = textBox1.Text;
            var momento = DateTime.Now;
            FeNa = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Mail = textBox2.Text;
            Tel = textBox3.Text;
            Fe = momento.ToString("yyyy-MM-dd");
            Ho = momento.ToString("HH:mm:ss");

            if (Nom == "" || FeNa == "" || Mail == "" || Tel == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

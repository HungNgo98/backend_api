using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ClassFom form3 = new ClassFom();
            form3.ShowDialog();
            this.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm form2 = new StudentForm();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Activate(); 
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void quảnLíSinhViênVàLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

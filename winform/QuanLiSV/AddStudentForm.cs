using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSV
{
    public partial class AddStudentForm : Form
    {
        SqlConnection con = new SqlConnection(@"data source=OMS-PC-202\SQLEXPRESS;Initial Catalog=Classroom;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
           
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbaddname.Text = "";
            tbaddsex.Text="";
            tbaddname.Text = "";
            tbaddclass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into dbo.Student values(N'" + tbaddname.Text + "',N'" + tbaddage.Text + "',N'" + tbaddclass.Text + "',N'" + tbaddsex.Text + "')";         
            con.Close();

        }
        //public void Display()
        //{
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    adapt = new SqlDataAdapter("select * from dbo.Student", con);
        //    adapt.Fill(dt);
        //    DtgvStudent.DataSource = dt;
        //    con.Close();
        //}
    }
}

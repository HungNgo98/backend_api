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

    public partial class StudentForm : Form
    {
        SqlConnection con = new SqlConnection(@"data source=OMS-PC-202\SQLEXPRESS;Initial Catalog=Classroom;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;      
        public StudentForm()
        {
            InitializeComponent();
        }

        //public void LoadData()
        //{
        //    ClassroomEntities db = new ClassroomEntities();
        //    DtgvStudent.DataSource = db.Students.ToString();

        //}
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classroomDataSet2.Student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter1.Fill(this.classroomDataSet2.Student);
            // TODO: This line of code loads data into the 'classroomDataSet.Student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter.Fill(this.classroomDataSet.Student);
            // TODO: This line of code loads data into the 'classroomDataSet.Classroom' table. You can move, or remove it, as needed.
            //this.classroomTableAdapter.Fill(this.classroomDataSet.Classroom);
            //LoadData();
            Display();
              
        }
        public void SearchKey()
        {
            ClassroomEntities db = new ClassroomEntities();
            //con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Student where Name like'%" + txtSearch.Text + "%' Or Age like'%" + txtSearch.Text + "%' Or CLass like '%" + txtSearch.Text + "' Or Sex like '" + txtSearch.Text + "'", con); ;
            adapt.Fill(dt);
            DtgvStudent.DataSource = dt;
            //con.Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClassroomEntities db = new ClassroomEntities();
            //con.Open();
            //DataTable dt = new DataTable();
            //adapt = new SqlDataAdapter("select * from dbo.Student where Name like'%" + txtSearch.Text + "%' Or Age like'%" + txtSearch.Text + "%' Or CLass like '%" + txtSearch.Text + "' Or Sex like '" + txtSearch.Text + "'", con); ;
            //adapt.Fill(dt);
            //DtgvStudent.DataSource = dt;
            //con.Close();
            SearchKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "delete dbo.Student where Name= '" + tbnamestudentform.Text + "'";
                //var cmd = new SqlCommand("delete dbo.Student where Name= '" + tbnamestudentform.Text + "'");
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.button4.Show();
            }
            
            

        }
        public void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Student", con);
            adapt.Fill(dt);
            DtgvStudent.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
            this.Show();
        }

        private void DtgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DtgvStudent.CurrentRow.Index;
            tbnamestudentform.Text = DtgvStudent.Rows[i].Cells[0].Value.ToString();
            tbagetudentform.Text = DtgvStudent.Rows[i].Cells[1].Value.ToString();
            tbclasstudentform.Text = DtgvStudent.Rows[i].Cells[2].Value.ToString();
            tbsextudentform.Text = DtgvStudent.Rows[i].Cells[3].Value.ToString();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update dbo.Student set Name='"+tbnamestudentform.Text+"',Age='"+tbagetudentform.Text+"',Class='"+tbclasstudentform.Text+"',Sex='"+tbsextudentform.Text+"'";
            //var cmd = new SqlCommand("update dbo.Student set Name='" + tbnamestudentform.Text + "',Age='" + tbagetudentform.Text + "',Class='" + tbclasstudentform.Text + "',Sex='" + tbsextudentform.Text + "'");
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
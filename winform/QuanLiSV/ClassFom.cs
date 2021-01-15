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
    public partial class ClassFom : Form
    {
        SqlConnection con = new SqlConnection(@"data source=OMS-PC-202\SQLEXPRESS;initial catalog=Classroom;integrated security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public ClassFom()
        {
            InitializeComponent();
        }
        #region
        void LoadData()
        {
            ClassroomEntities db = new ClassroomEntities();
            dtgvDataClass.DataSource = db.Classrooms.ToList();
        }
        #endregion
        private void Form3_Load(object sender, EventArgs e)
        {
            
           LoadData();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(txt_CLass.Text != "")
            {
                cmd = new SqlCommand(" insert into dbo.Classroom(Class) values(@Class)",con);
                con.Open();
                cmd.Parameters.AddWithValue("@Class", txt_CLass.Text);
               // cmd.Parameters.Add();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("insert success!");
                Display();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please insert value ");
            }
        }
        public void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Classroom",con);
            adapt.Fill(dt);
            dtgvDataClass.DataSource = dt;          
            con.Close();
           
        }
        public void ClearData()
        {
            txt_CLass.Text = "";
        }
    }
}

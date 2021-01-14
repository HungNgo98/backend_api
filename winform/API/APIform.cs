using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace API
{
    public partial class APIform : Form
    {
        public APIform()
        {
            InitializeComponent();
        }

        private void APform_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User() { id = int.Parse(textBox1.Text), name = Tên.Text, sex = Sex.Text, email = Gmail.Text, password = Password.Text, password_confirmation = password_confirm.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000");
            HttpResponseMessage response = client.DeleteAsync($"api/user/delete/{user.id}").Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000");
            HttpResponseMessage response = client.GetAsync("api/user/getlist").Result;
            var account = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
            dataGridView1.DataSource = account;           
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            //var account = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User() { name = Tên.Text, sex = Sex.Text, email = Gmail.Text, password = Password.Text, password_confirmation = password_confirm.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000");
            HttpResponseMessage response = client.PostAsJsonAsync("api/user/create", user).Result;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            User user = new User() { id = int.Parse(textBox1.Text), name = Tên.Text, sex = Sex.Text, email = Gmail.Text, password = Password.Text, password_confirmation = password_confirm.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000");
            HttpResponseMessage response = client.PostAsJsonAsync($"api/user/update/{user.id}",user).Result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // this.dataGridView1.Columns[4].Visible = false;
           dataGridView1.Columns[4].Visible = false;
           dataGridView1.Columns[5].Visible = false;
           

        }
    }
}

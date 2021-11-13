using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SchoolManagementSystem
{
    public partial class DeleteStudent : Form
    {
      
      
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet1.student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter.Fill(this.schoolDataSet1.student);
            SqlConnection con = new SqlConnection(@"Data Source=alaa;Initial Catalog=F:\SEM.4\C# PROJECTS\SCHOOLMANAGEMENTSYSTEM\SCHOOLMANAGEMENTSYSTEM\SCHOOL.MDF;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * From student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Registration number");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=alaa;Initial Catalog=F:\SEM.4\C# PROJECTS\SCHOOLMANAGEMENTSYSTEM\SCHOOLMANAGEMENTSYSTEM\SCHOOL.MDF;Integrated Security=True"))
                {

                    string str = "DELETE FROM student WHERE std_id = '" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=alaa;Initial Catalog=F:\SEM.4\C# PROJECTS\SCHOOLMANAGEMENTSYSTEM\SCHOOLMANAGEMENTSYSTEM\SCHOOL.MDF;Integrated Security=True"))
            {

                string str = "SELECT * FROM student";
                SqlCommand cmd = new SqlCommand(str, con);
              SqlDataAdapter   da = new SqlDataAdapter(cmd);
              DataTable   dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}

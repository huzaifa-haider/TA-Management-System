using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Task : Form
    {
        public string username;
        functions myfun = new functions();
        public Task()
        {
            InitializeComponent();
            username = Form1.global_userName;
            loadTask();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            student std = new student();
            std.Visible = true;
            this.Visible = false;
        }

        public void addColumn()
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Done", "Done");

        }

        public void loadTask()
        {
            dataGridView1.Rows.Clear();

            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //string query = "select  s.student_id ,ssc.course_code,s.name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade"+
            //    "from student as s inner join application as a on s.student_id=a.student_id "+
            //    "inner join student_select_course as ssc on ssc.student_id=s.student_id;";

            string query = "select name ,description,Done from task";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                addColumn();

                while (dr.Read())
                {

                    string name = dr["name"].ToString();
                    string desc = dr["description"].ToString();
                    string done = dr["Done"].ToString();
                    dataGridView1.Rows.Add(name, desc,done);

                }

            }
            else
            {
                MessageBox.Show("No Data");
            }
        }



        private void doneBtn_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE task SET Done= 1  WHERE student_id ='" + username + "';";
            myfun.insertIntoDB(query);
            loadTask();

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

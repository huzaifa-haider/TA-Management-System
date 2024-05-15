using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project1
{

    public partial class admin : Form
    {


        functions myfun = new functions();
        public string username;
        public admin()
        {
            InitializeComponent();
            loadApplications();
            username = Form1.global_userName;
            // Attach the SelectionChanged event handler to the DataGridView
            //dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }

        private string DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string student_id = "";
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Access the values in the selected row
                student_id = selectedRow.Cells["University ID"].Value.ToString();

            }
            return student_id;
        }

        private string getCourseFromGrid(object sender, EventArgs e)
        {
            string data = "";
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Access the values in the selected row
                data = selectedRow.Cells["Course_Code"].Value.ToString();

            }
            return data;
        }





        private void changepassBtn_Click(object sender, EventArgs e)
        {
            // Replace "YourConnectionString" with your actual database connection string
            string connectionString = "Data Source = HUZAIFA_MALIK\\SQLEXPRESS; Initial Catalog = TAManagmentSys; Integrated Security = True";

            DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

            // Replace "SELECT * FROM YourTableName" with your actual SQL query
            string query = "SELECT * FROM student";

            DataTable result = dbHelper.ExecuteQuery(query);

            // Process the result DataTable as needed
            foreach (DataRow row in result.Rows)
            {
                foreach (DataColumn col in result.Columns)
                {
                    Console.Write($"{col.ColumnName}: {row[col]}   ");
                }
                Console.WriteLine();
            }





            changePass cp = new changePass();
            cp.Visible = true;
            this.Visible = false;

        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {

            Form1 login = new Form1();
            login.Visible = true;
            this.Visible = false;
        }
        public void addColumn()
        {
            dataGridView1.Columns.Add("University ID", "University ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Department", "Department");
            dataGridView1.Columns.Add("status", "status");
            dataGridView1.Columns.Add("employee_id", "employee_id");
            dataGridView1.Columns.Add("contact", "contact");
            dataGridView1.Columns.Add("Qualification", "Qualification");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Grade", "Grade");
            dataGridView1.Columns.Add("Course_Code", "Course_Code");

        }
        public void loadApplications()
        {
            //dataGridView1.Rows.Clear();

            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //string query = "select  s.student_id ,ssc.course_code,s.name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade"+
            //    "from student as s inner join application as a on s.student_id=a.student_id "+
            //    "inner join student_select_course as ssc on ssc.student_id=s.student_id;";

            string query = "select  s.student_id ,ssc.course_code,s.name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade from student as s inner join application as a on s.student_id=a.student_id inner join student_select_course as ssc on ssc.student_id=s.student_id;";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                addColumn();

                while (dr.Read())
                {
                    string student_id = dr["student_id"].ToString();
                    string name = dr["name"].ToString();
                    string dept = dr["dept"].ToString();
                    string status = dr["status"].ToString();
                    string employee_id = dr["employee_id"].ToString();
                    string contact = dr["contact"].ToString();
                    string quali = dr["qualification"].ToString();
                    string email = dr["email"].ToString();
                    string grade = dr["grade"].ToString();
                    string course_code = dr["course_code"].ToString();


                    dataGridView1.Rows.Add(student_id, name, dept, status, employee_id, contact, quali, email, grade, course_code);

                }

            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            string student_id = DataGridView1_SelectionChanged(sender, e);

           
            string course_code = getCourseFromGrid(sender, e);
            //MessageBox.Show("course_code recieced: " + course_code);

            string retriveFaculty = "select employee_id from employee_teaches_course where course_code='"+course_code+"'";

            string fac = myfun.getOneValue(retriveFaculty,"course_code");



            string insertIntoEmpHasStudents = "insert into employee_has_students values('"+student_id+"','"+fac+"')";
            myfun.insertIntoDB(insertIntoEmpHasStudents);

            string query = "UPDATE application SET status = 1, employee_id= '" + username + "' WHERE student_id ='" + student_id + "';";

            //MessageBox.Show("id received: " + student_id);
            myfun.insertIntoDB(query);
            loadApplications();


        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            string student_id = DataGridView1_SelectionChanged(sender, e);

            // string emp = "";
            string query = "UPDATE application SET status = 0 , employee_id= null  WHERE student_id ='" + student_id + "';";
            //string query = "exec insertDataApplication  @status=0 ,@student_id='" + username + "',@employee_id =null,@contact= '" + contact + "',@qualification= '" + qualification + "',@email= '" + email + "',@grade= '" + grade + "',@type='" + type + "';";

            //MessageBox.Show("id received: " + student_id);
            myfun.insertIntoDB(query);

            loadApplications();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

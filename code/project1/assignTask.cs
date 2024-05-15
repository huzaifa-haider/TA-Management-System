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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project1
{
    public partial class assignTask : Form
    {
        public string username;

        functions myfun = new functions();
        public assignTask()
        {
            InitializeComponent();
            username = Form1.global_userName;
        }
        

        private void assginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("username of faculty is" + username);

            string taskName = this.tasknameBx.Text;
            string desc = this.descBx.Text;

            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //string query = "select  s.student_id ,ssc.course_code,s.name,s.dept,a.status,a.employee_id,a.contact,a.qualification,a.email,a.grade"+
            //    "from student as s inner join application as a on s.student_id=a.student_id "+
            //    "inner join student_select_course as ssc on ssc.student_id=s.student_id;";

            string stdIDquery = "select ehs.student_id as student_id from employee_has_students as ehs inner join application as a on a.student_id=ehs.student_id";

            SqlCommand cmd = new SqlCommand(stdIDquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                //string student_id = dr["student_id"].ToString();

                string student_id = "21i-0784";
                
                
               
                string retriveCourseCode = "select course_code from employee_teaches_course where employee_id='ifrah.qaiser'";

                string course_code = myfun.getOneValue(retriveCourseCode,"employee_id");


                string query = "exec insertDataTask @t_name='" + taskName + "',@desc='" + desc + "',@student_id= '"+student_id+"' ,@employee_id='"+username+"' ,@course_code='"+course_code+"'";

                myfun.insertIntoDB(query);


            }
            else
            {
                MessageBox.Show("You have no TA/LD");
            }


            Faculty fac=new Faculty();
            fac.Visible = true;
            this.Visible = false;

        }
    }
}

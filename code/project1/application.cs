using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project1
{
    public partial class application : Form
    {
        public string username;

        public application()
        {
            InitializeComponent();
            username = Form1.global_userName;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

            functions myfun = new functions();
            Form1 login = new Form1();
            student std = new student();

            string qualification = this.qualificationBx.Text;
            string email = this.emailBx.Text;
            string contact = this.contactBx.Text;
            string grade = this.gradeBx.Text;
            string type = this.typeBx.Text;


            string querySSC = "insert into student_select_course(student_id,course_code) values( '" + username + "','" + this.coursecodeBx.Text + "');";
            //MessageBox.Show("Username is: " + username);
            string query = "exec insertDataApplication  @status=0 ,@student_id='" + username + "',@employee_id =null,@contact= '" + contact + "',@qualification= '" + qualification + "',@email= '" + email + "',@grade= '" + grade + "',@type='" + type + "';";


            int resSSC = myfun.insertIntoDB(querySSC);

            if (resSSC > 0)
            {
                int res = myfun.insertIntoDB(query);

                if (res > 0)
                {
                    MessageBox.Show("Thanks for Applying\n");
                    std.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error in Applying\n Please try again");
                }

            }
            else
            {
                MessageBox.Show("Course is not offered OR\n Wrong Course code");
            }




        }

    }
}

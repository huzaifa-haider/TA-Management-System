using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project1
{

    public partial class Form1 : Form
    {
        functions myfun=new functions();
        public static string global_userName = "";

        public Form1()
        {
            InitializeComponent();
            showpasswordcheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            this.showpasswordcheckBox.Checked = false;
            global_userName = this.usernameBx.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(myfun.getOneValue("select top(1) student_id from student","student_id"));

            string userName = this.usernameBx.Text;
            global_userName = userName;
            string pass = this.passBx.Text;

            //globelUserName = userName;

            //conString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //string querry = "select userName,userPassword from users" + "where userName= " + userName + " and userPassword= " + pass;
            string querry = "select * from credential where username= @enteredUser AND password= @enteredPass";

            SqlCommand cmd = new SqlCommand(querry, con);


            cmd.Parameters.AddWithValue("@enteredUser", userName);
            cmd.Parameters.AddWithValue("@enteredPass", pass);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                string type = reader["type"].ToString();

                if (type == "admin")
                {

                    admin ad = new admin();
                    ad.Visible = true;
                    this.Visible = false;

                }
                else if (type == "student")
                {

                    student std = new student();
                    std.Visible = true;
                    this.Visible = false;


                }
                else if (type == "faculty")
                {
                    Faculty fac = new Faculty();
                    fac.Visible = true;
                    this.Visible = false;

                }
                else if (type == "hod")
                {
                    HOD hod = new HOD();
                    hod.Visible = true;
                    this.Visible = false;

                }


                else
                {
                    MessageBox.Show("Invalid type in credentials");

                }


            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }



        }
        public string getUsername()
        {
            return global_userName;
        }
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password visibility based on the checkbox state
            passBx.UseSystemPasswordChar = !showpasswordcheckBox.Checked;
        }

    }
}
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
    public partial class student : Form
    {

        functions myfun = new functions();
        public string username;
        public student()
        {
            InitializeComponent();
            username = Form1.global_userName;
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Visible = true;
            this.Visible = false;
        }

        private void changepassBtn_Click(object sender, EventArgs e)
        {
            changePass cp = new changePass();
            cp.Visible = true;
            this.Visible = false;

        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            application app = new application();
            app.Visible = true;
            this.Visible = false;

        }

        private void viewtaskBtn_Click(object sender, EventArgs e)
        {
            string query = "select status from application where student_id='" + username + "'";

            
            //int resView =myfun.insertIntoDB(query);

            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            

            if (dr.HasRows)
            {
                //  while (dr.Read())
                //  {
                dr.Read();
                bool status = (bool)dr["status"];
                if (status)
                {
                    Task myTask = new Task();
                    myTask.Visible = true;
                    this.Visible = false;
                }
                //}

            }
            else
            {
                MessageBox.Show("Not selected");
            }
        }
    }
}

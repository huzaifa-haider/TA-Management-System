using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace project1
{
    public partial class changePass : Form
        
    {
        public string username;
        public changePass()
        {
            InitializeComponent();
            username = Form1.global_userName;
        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            functions myfun=new functions();
            Form1 login = new Form1();

            string new_pass = this.newPassBx.Text;
            if (this.newPassBx.Text == this.confirmPassBx.Text)
            {
                MessageBox.Show("Username is: " + username);
                string query = "UPDATE credential SET password = '" + new_pass + "' WHERE username = '" + username + "';";
                int res = myfun.insertIntoDB(query);

                if (res > 0)
                {
                    MessageBox.Show("Password Updated Successfully\nPlease Login Again");
                    login.Visible = true;
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Error in updating Password");
                }


            }
            else
            {
                MessageBox.Show("Password doesn't Match\n Try Agin");
            }







        }
    }
}

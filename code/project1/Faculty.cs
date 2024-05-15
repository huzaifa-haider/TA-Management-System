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

namespace project1
{
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
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

            //    string querry = "insert into task values " + "('" + name + "','" + description + "','" + dueDate + "','" + priority + "','" + status + "','" + userID + "')";

            //    if (res > 0)
            //    {
            //        MessageBox.Show("Task Added Successfully");
            //        Form3 form3 = new Form3();
            //        form3.Visible = true;
            //        this.Visible = false;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Error in adding task");
            //    }
            //    con.Close();
            //
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            assignTask at=new assignTask();
            at.Visible = true;
            this.Visible=false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class HOD : Form
    {
        public HOD()
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

        }
    }
}

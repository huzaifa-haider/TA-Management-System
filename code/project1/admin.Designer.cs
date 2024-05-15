namespace project1
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            changepassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            signoutBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            rejectBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            approveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            dataGridView1 = new DataGridView();
            bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // changepassBtn
            // 
            changepassBtn.ActiveBorderThickness = 1;
            changepassBtn.ActiveCornerRadius = 20;
            changepassBtn.ActiveFillColor = Color.SeaGreen;
            changepassBtn.ActiveForecolor = Color.Transparent;
            changepassBtn.ActiveLineColor = Color.SeaGreen;
            changepassBtn.BackColor = Color.White;
            changepassBtn.BackgroundImage = (Image)resources.GetObject("changepassBtn.BackgroundImage");
            changepassBtn.ButtonText = "Change Password";
            changepassBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changepassBtn.ForeColor = Color.SeaGreen;
            changepassBtn.IdleBorderThickness = 1;
            changepassBtn.IdleCornerRadius = 20;
            changepassBtn.IdleFillColor = Color.White;
            changepassBtn.IdleForecolor = Color.SeaGreen;
            changepassBtn.IdleLineColor = Color.SeaGreen;
            changepassBtn.Location = new Point(5, 68);
            changepassBtn.Margin = new Padding(5);
            changepassBtn.Name = "changepassBtn";
            changepassBtn.Size = new Size(130, 54);
            changepassBtn.TabIndex = 10;
            changepassBtn.TextAlign = ContentAlignment.MiddleCenter;
            changepassBtn.Click += changepassBtn_Click;
            // 
            // signoutBtn
            // 
            signoutBtn.ActiveBorderThickness = 1;
            signoutBtn.ActiveCornerRadius = 20;
            signoutBtn.ActiveFillColor = Color.SeaGreen;
            signoutBtn.ActiveForecolor = Color.Transparent;
            signoutBtn.ActiveLineColor = Color.SeaGreen;
            signoutBtn.BackColor = Color.White;
            signoutBtn.BackgroundImage = (Image)resources.GetObject("signoutBtn.BackgroundImage");
            signoutBtn.ButtonText = "SignOut";
            signoutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signoutBtn.ForeColor = Color.SeaGreen;
            signoutBtn.IdleBorderThickness = 1;
            signoutBtn.IdleCornerRadius = 20;
            signoutBtn.IdleFillColor = Color.White;
            signoutBtn.IdleForecolor = Color.SeaGreen;
            signoutBtn.IdleLineColor = Color.SeaGreen;
            signoutBtn.Location = new Point(5, 11);
            signoutBtn.Margin = new Padding(5);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(130, 47);
            signoutBtn.TabIndex = 9;
            signoutBtn.TextAlign = ContentAlignment.MiddleCenter;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.Controls.Add(rejectBtn);
            bunifuCards1.Controls.Add(approveBtn);
            bunifuCards1.Controls.Add(changepassBtn);
            bunifuCards1.Controls.Add(signoutBtn);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(1741, 3);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(140, 496);
            bunifuCards1.TabIndex = 11;
            // 
            // rejectBtn
            // 
            rejectBtn.ActiveBorderThickness = 1;
            rejectBtn.ActiveCornerRadius = 20;
            rejectBtn.ActiveFillColor = Color.SeaGreen;
            rejectBtn.ActiveForecolor = Color.Transparent;
            rejectBtn.ActiveLineColor = Color.SeaGreen;
            rejectBtn.BackColor = Color.White;
            rejectBtn.BackgroundImage = (Image)resources.GetObject("rejectBtn.BackgroundImage");
            rejectBtn.ButtonText = "Reject";
            rejectBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rejectBtn.ForeColor = Color.SeaGreen;
            rejectBtn.IdleBorderThickness = 1;
            rejectBtn.IdleCornerRadius = 20;
            rejectBtn.IdleFillColor = Color.White;
            rejectBtn.IdleForecolor = Color.SeaGreen;
            rejectBtn.IdleLineColor = Color.SeaGreen;
            rejectBtn.Location = new Point(5, 189);
            rejectBtn.Margin = new Padding(5);
            rejectBtn.Name = "rejectBtn";
            rejectBtn.Size = new Size(130, 47);
            rejectBtn.TabIndex = 13;
            rejectBtn.TextAlign = ContentAlignment.MiddleCenter;
            rejectBtn.Click += rejectBtn_Click;
            // 
            // approveBtn
            // 
            approveBtn.ActiveBorderThickness = 1;
            approveBtn.ActiveCornerRadius = 20;
            approveBtn.ActiveFillColor = Color.SeaGreen;
            approveBtn.ActiveForecolor = Color.Transparent;
            approveBtn.ActiveLineColor = Color.SeaGreen;
            approveBtn.BackColor = Color.White;
            approveBtn.BackgroundImage = (Image)resources.GetObject("approveBtn.BackgroundImage");
            approveBtn.ButtonText = "Approve";
            approveBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            approveBtn.ForeColor = Color.SeaGreen;
            approveBtn.IdleBorderThickness = 1;
            approveBtn.IdleCornerRadius = 20;
            approveBtn.IdleFillColor = Color.White;
            approveBtn.IdleForecolor = Color.SeaGreen;
            approveBtn.IdleLineColor = Color.SeaGreen;
            approveBtn.Location = new Point(5, 132);
            approveBtn.Margin = new Padding(5);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(130, 47);
            approveBtn.TabIndex = 12;
            approveBtn.TextAlign = ContentAlignment.MiddleCenter;
            approveBtn.Click += approveBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(27, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1311, 302);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 986);
            Controls.Add(dataGridView1);
            Controls.Add(bunifuCards1);
            Name = "admin";
            Text = "admin";
            bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 changepassBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 signoutBtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 approveBtn;
        private DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 rejectBtn;
    }
}
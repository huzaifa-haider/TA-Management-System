namespace project1
{
    partial class Faculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculty));
            signoutBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            changepassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            assignBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            viewtaskBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
            // 
            // signoutBtn
            // 
            signoutBtn.ActiveBorderThickness = 1;
            signoutBtn.ActiveCornerRadius = 20;
            signoutBtn.ActiveFillColor = Color.SeaGreen;
            signoutBtn.ActiveForecolor = Color.Transparent;
            signoutBtn.ActiveLineColor = Color.SeaGreen;
            signoutBtn.BackColor = Color.Gainsboro;
            signoutBtn.BackgroundImage = (Image)resources.GetObject("signoutBtn.BackgroundImage");
            signoutBtn.ButtonText = "SignOut";
            signoutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signoutBtn.ForeColor = Color.SeaGreen;
            signoutBtn.IdleBorderThickness = 1;
            signoutBtn.IdleCornerRadius = 20;
            signoutBtn.IdleFillColor = Color.White;
            signoutBtn.IdleForecolor = Color.SeaGreen;
            signoutBtn.IdleLineColor = Color.SeaGreen;
            signoutBtn.Location = new Point(25, 5);
            signoutBtn.Margin = new Padding(5);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(108, 47);
            signoutBtn.TabIndex = 7;
            signoutBtn.TextAlign = ContentAlignment.MiddleCenter;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // changepassBtn
            // 
            changepassBtn.ActiveBorderThickness = 1;
            changepassBtn.ActiveCornerRadius = 20;
            changepassBtn.ActiveFillColor = Color.SeaGreen;
            changepassBtn.ActiveForecolor = Color.Transparent;
            changepassBtn.ActiveLineColor = Color.SeaGreen;
            changepassBtn.BackColor = Color.Gainsboro;
            changepassBtn.BackgroundImage = (Image)resources.GetObject("changepassBtn.BackgroundImage");
            changepassBtn.ButtonText = "Change Password";
            changepassBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changepassBtn.ForeColor = Color.SeaGreen;
            changepassBtn.IdleBorderThickness = 1;
            changepassBtn.IdleCornerRadius = 20;
            changepassBtn.IdleFillColor = Color.White;
            changepassBtn.IdleForecolor = Color.SeaGreen;
            changepassBtn.IdleLineColor = Color.SeaGreen;
            changepassBtn.Location = new Point(8, 62);
            changepassBtn.Margin = new Padding(5);
            changepassBtn.Name = "changepassBtn";
            changepassBtn.Size = new Size(143, 54);
            changepassBtn.TabIndex = 8;
            changepassBtn.TextAlign = ContentAlignment.MiddleCenter;
            changepassBtn.Click += changepassBtn_Click;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.Gainsboro;
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.Controls.Add(changepassBtn);
            bunifuCards1.Controls.Add(signoutBtn);
            bunifuCards1.Controls.Add(assignBtn);
            bunifuCards1.Controls.Add(viewtaskBtn);
            bunifuCards1.Controls.Add(bunifuThinButton21);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(1744, 12);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(156, 1023);
            bunifuCards1.TabIndex = 12;
            // 
            // assignBtn
            // 
            assignBtn.ActiveBorderThickness = 1;
            assignBtn.ActiveCornerRadius = 20;
            assignBtn.ActiveFillColor = Color.SeaGreen;
            assignBtn.ActiveForecolor = Color.Transparent;
            assignBtn.ActiveLineColor = Color.SeaGreen;
            assignBtn.BackColor = Color.Gainsboro;
            assignBtn.BackgroundImage = (Image)resources.GetObject("assignBtn.BackgroundImage");
            assignBtn.ButtonText = "Assign Task";
            assignBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            assignBtn.ForeColor = Color.SeaGreen;
            assignBtn.IdleBorderThickness = 1;
            assignBtn.IdleCornerRadius = 20;
            assignBtn.IdleFillColor = Color.White;
            assignBtn.IdleForecolor = Color.SeaGreen;
            assignBtn.IdleLineColor = Color.SeaGreen;
            assignBtn.Location = new Point(13, 126);
            assignBtn.Margin = new Padding(5);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(138, 47);
            assignBtn.TabIndex = 13;
            assignBtn.TextAlign = ContentAlignment.MiddleCenter;
            assignBtn.Click += assignBtn_Click;
            // 
            // viewtaskBtn
            // 
            viewtaskBtn.ActiveBorderThickness = 1;
            viewtaskBtn.ActiveCornerRadius = 20;
            viewtaskBtn.ActiveFillColor = Color.SeaGreen;
            viewtaskBtn.ActiveForecolor = Color.Transparent;
            viewtaskBtn.ActiveLineColor = Color.SeaGreen;
            viewtaskBtn.BackColor = Color.Gainsboro;
            viewtaskBtn.BackgroundImage = (Image)resources.GetObject("viewtaskBtn.BackgroundImage");
            viewtaskBtn.ButtonText = "View Task";
            viewtaskBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewtaskBtn.ForeColor = Color.SeaGreen;
            viewtaskBtn.IdleBorderThickness = 1;
            viewtaskBtn.IdleCornerRadius = 20;
            viewtaskBtn.IdleFillColor = Color.White;
            viewtaskBtn.IdleForecolor = Color.SeaGreen;
            viewtaskBtn.IdleLineColor = Color.SeaGreen;
            viewtaskBtn.Location = new Point(13, 430);
            viewtaskBtn.Margin = new Padding(5);
            viewtaskBtn.Name = "viewtaskBtn";
            viewtaskBtn.Size = new Size(138, 47);
            viewtaskBtn.TabIndex = 12;
            viewtaskBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            bunifuThinButton21.ActiveForecolor = Color.Transparent;
            bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton21.BackColor = Color.Gainsboro;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "SignOut";
            bunifuThinButton21.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.SeaGreen;
            bunifuThinButton21.IdleLineColor = Color.SeaGreen;
            bunifuThinButton21.Location = new Point(13, 487);
            bunifuThinButton21.Margin = new Padding(5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(138, 47);
            bunifuThinButton21.TabIndex = 11;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(bunifuCards1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Faculty";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Faculty";
            bunifuCards1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 signoutBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 changepassBtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 assignBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 viewtaskBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
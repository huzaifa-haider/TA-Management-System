namespace project1
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            changepassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            signoutBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            applyBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            viewtaskBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
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
            changepassBtn.Location = new Point(13, 62);
            changepassBtn.Margin = new Padding(5);
            changepassBtn.Name = "changepassBtn";
            changepassBtn.Size = new Size(143, 54);
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
            signoutBtn.Location = new Point(13, 5);
            signoutBtn.Margin = new Padding(5);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(138, 47);
            signoutBtn.TabIndex = 9;
            signoutBtn.TextAlign = ContentAlignment.MiddleCenter;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.Gainsboro;
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.Controls.Add(applyBtn);
            bunifuCards1.Controls.Add(viewtaskBtn);
            bunifuCards1.Controls.Add(bunifuThinButton21);
            bunifuCards1.Controls.Add(changepassBtn);
            bunifuCards1.Controls.Add(signoutBtn);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(1745, 3);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(156, 1023);
            bunifuCards1.TabIndex = 11;
            // 
            // applyBtn
            // 
            applyBtn.ActiveBorderThickness = 1;
            applyBtn.ActiveCornerRadius = 20;
            applyBtn.ActiveFillColor = Color.SeaGreen;
            applyBtn.ActiveForecolor = Color.Transparent;
            applyBtn.ActiveLineColor = Color.SeaGreen;
            applyBtn.BackColor = Color.Gainsboro;
            applyBtn.BackgroundImage = (Image)resources.GetObject("applyBtn.BackgroundImage");
            applyBtn.ButtonText = "Apply";
            applyBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applyBtn.ForeColor = Color.SeaGreen;
            applyBtn.IdleBorderThickness = 1;
            applyBtn.IdleCornerRadius = 20;
            applyBtn.IdleFillColor = Color.White;
            applyBtn.IdleForecolor = Color.SeaGreen;
            applyBtn.IdleLineColor = Color.SeaGreen;
            applyBtn.Location = new Point(13, 126);
            applyBtn.Margin = new Padding(5);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(138, 47);
            applyBtn.TabIndex = 13;
            applyBtn.TextAlign = ContentAlignment.MiddleCenter;
            applyBtn.Click += applyBtn_Click;
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
            viewtaskBtn.Location = new Point(9, 183);
            viewtaskBtn.Margin = new Padding(5);
            viewtaskBtn.Name = "viewtaskBtn";
            viewtaskBtn.Size = new Size(138, 47);
            viewtaskBtn.TabIndex = 12;
            viewtaskBtn.TextAlign = ContentAlignment.MiddleCenter;
            viewtaskBtn.Click += viewtaskBtn_Click;
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
            bunifuThinButton21.Location = new Point(9, 240);
            bunifuThinButton21.Margin = new Padding(5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(138, 47);
            bunifuThinButton21.TabIndex = 11;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(bunifuCards1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "student";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = " ";
            bunifuCards1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 changepassBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 signoutBtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 applyBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 viewtaskBtn;
    }
}
namespace project1
{
    partial class HOD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOD));
            changepassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            signoutBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            SuspendLayout();
            // 
            // changepassBtn
            // 
            changepassBtn.ActiveBorderThickness = 1;
            changepassBtn.ActiveCornerRadius = 20;
            changepassBtn.ActiveFillColor = Color.SeaGreen;
            changepassBtn.ActiveForecolor = Color.Transparent;
            changepassBtn.ActiveLineColor = Color.SeaGreen;
            changepassBtn.BackColor = Color.FromArgb(192, 192, 255);
            changepassBtn.BackgroundImage = (Image)resources.GetObject("changepassBtn.BackgroundImage");
            changepassBtn.ButtonText = "Change Password";
            changepassBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changepassBtn.ForeColor = Color.SeaGreen;
            changepassBtn.IdleBorderThickness = 1;
            changepassBtn.IdleCornerRadius = 20;
            changepassBtn.IdleFillColor = Color.White;
            changepassBtn.IdleForecolor = Color.SeaGreen;
            changepassBtn.IdleLineColor = Color.SeaGreen;
            changepassBtn.Location = new Point(636, 71);
            changepassBtn.Margin = new Padding(5);
            changepassBtn.Name = "changepassBtn";
            changepassBtn.Size = new Size(160, 54);
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
            signoutBtn.BackColor = Color.FromArgb(192, 192, 255);
            signoutBtn.BackgroundImage = (Image)resources.GetObject("signoutBtn.BackgroundImage");
            signoutBtn.ButtonText = "SignOut";
            signoutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signoutBtn.ForeColor = Color.SeaGreen;
            signoutBtn.IdleBorderThickness = 1;
            signoutBtn.IdleCornerRadius = 20;
            signoutBtn.IdleFillColor = Color.White;
            signoutBtn.IdleForecolor = Color.SeaGreen;
            signoutBtn.IdleLineColor = Color.SeaGreen;
            signoutBtn.Location = new Point(678, 14);
            signoutBtn.Margin = new Padding(5);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(108, 47);
            signoutBtn.TabIndex = 9;
            signoutBtn.TextAlign = ContentAlignment.MiddleCenter;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // HOD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(changepassBtn);
            Controls.Add(signoutBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HOD";
            Text = "HOD";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 changepassBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 signoutBtn;
    }
}
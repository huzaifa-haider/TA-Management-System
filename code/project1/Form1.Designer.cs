namespace project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            usernameBx = new TextBox();
            passBx = new TextBox();
            showpasswordcheckBox = new CheckBox();
            loginBtn = new Button();
            comboBox1 = new ComboBox();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // usernameBx
            // 
            usernameBx.BackColor = SystemColors.Control;
            usernameBx.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            usernameBx.Location = new Point(938, 369);
            usernameBx.Multiline = true;
            usernameBx.Name = "usernameBx";
            usernameBx.Size = new Size(359, 45);
            usernameBx.TabIndex = 0;
            usernameBx.Tag = "";
            usernameBx.Text = "ifrah.qaiser";
            usernameBx.TextChanged += textBox1_TextChanged;
            // 
            // passBx
            // 
            passBx.Location = new Point(938, 433);
            passBx.Multiline = true;
            passBx.Name = "passBx";
            passBx.Size = new Size(359, 54);
            passBx.TabIndex = 1;
            passBx.Text = "ifrah123";
            // 
            // showpasswordcheckBox
            // 
            showpasswordcheckBox.AutoSize = true;
            showpasswordcheckBox.Location = new Point(905, 512);
            showpasswordcheckBox.Name = "showpasswordcheckBox";
            showpasswordcheckBox.Size = new Size(132, 24);
            showpasswordcheckBox.TabIndex = 4;
            showpasswordcheckBox.Text = "show password";
            showpasswordcheckBox.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Bottom;
            loginBtn.Location = new Point(997, 559);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(102, 44);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(822, 616);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.Indigo;
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(128, 142);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(1666, 92);
            bunifuCards1.TabIndex = 11;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "Password";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Iconcolor = Color.FromArgb(0, 0, 192);
            bunifuFlatButton1.Iconimage = (Image)resources.GetObject("bunifuFlatButton1.Iconimage");
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(689, 433);
            bunifuFlatButton1.Margin = new Padding(4, 5, 4, 5);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(216, 54);
            bunifuFlatButton1.TabIndex = 12;
            bunifuFlatButton1.Text = "Password";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // bunifuFlatButton2
            // 
            bunifuFlatButton2.Active = false;
            bunifuFlatButton2.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton2.BorderRadius = 0;
            bunifuFlatButton2.ButtonText = "username";
            bunifuFlatButton2.DisabledColor = Color.Gray;
            bunifuFlatButton2.Iconcolor = Color.FromArgb(0, 0, 192);
            bunifuFlatButton2.Iconimage = (Image)resources.GetObject("bunifuFlatButton2.Iconimage");
            bunifuFlatButton2.Iconimage_right = null;
            bunifuFlatButton2.Iconimage_right_Selected = null;
            bunifuFlatButton2.Iconimage_Selected = null;
            bunifuFlatButton2.IconMarginLeft = 0;
            bunifuFlatButton2.IconMarginRight = 0;
            bunifuFlatButton2.IconRightVisible = true;
            bunifuFlatButton2.IconRightZoom = 0D;
            bunifuFlatButton2.IconVisible = true;
            bunifuFlatButton2.IconZoom = 90D;
            bunifuFlatButton2.IsTab = false;
            bunifuFlatButton2.Location = new Point(689, 369);
            bunifuFlatButton2.Margin = new Padding(4, 5, 4, 5);
            bunifuFlatButton2.Name = "bunifuFlatButton2";
            bunifuFlatButton2.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton2.OnHoverTextColor = Color.White;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton2.Size = new Size(216, 54);
            bunifuFlatButton2.TabIndex = 13;
            bunifuFlatButton2.Text = "username";
            bunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton2.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(bunifuFlatButton2);
            Controls.Add(bunifuFlatButton1);
            Controls.Add(bunifuCards1);
            Controls.Add(comboBox1);
            Controls.Add(loginBtn);
            Controls.Add(showpasswordcheckBox);
            Controls.Add(passBx);
            Controls.Add(usernameBx);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBx;
        private TextBox passBx;
        private CheckBox showpasswordcheckBox;
        private Button loginBtn;
        private ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
namespace project1
{
    partial class assignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignTask));
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            assginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label2 = new Bunifu.Framework.UI.BunifuFlatButton();
            label1 = new Bunifu.Framework.UI.BunifuFlatButton();
            descBx = new TextBox();
            tasknameBx = new TextBox();
            Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.FromArgb(255, 224, 192);
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.Controls.Add(assginBtn);
            bunifuCards1.Controls.Add(label2);
            bunifuCards1.Controls.Add(label1);
            bunifuCards1.Controls.Add(descBx);
            bunifuCards1.Controls.Add(tasknameBx);
            bunifuCards1.Controls.Add(Button1);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(173, 35);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(363, 445);
            bunifuCards1.TabIndex = 2;
            // 
            // assginBtn
            // 
            assginBtn.ActiveBorderThickness = 1;
            assginBtn.ActiveCornerRadius = 20;
            assginBtn.ActiveFillColor = Color.SeaGreen;
            assginBtn.ActiveForecolor = Color.White;
            assginBtn.ActiveLineColor = Color.SeaGreen;
            assginBtn.BackColor = Color.FromArgb(255, 224, 192);
            assginBtn.BackgroundImage = (Image)resources.GetObject("assginBtn.BackgroundImage");
            assginBtn.ButtonText = "Assign";
            assginBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            assginBtn.ForeColor = Color.SeaGreen;
            assginBtn.IdleBorderThickness = 1;
            assginBtn.IdleCornerRadius = 20;
            assginBtn.IdleFillColor = Color.White;
            assginBtn.IdleForecolor = Color.SeaGreen;
            assginBtn.IdleLineColor = Color.SeaGreen;
            assginBtn.Location = new Point(60, 336);
            assginBtn.Margin = new Padding(5);
            assginBtn.Name = "assginBtn";
            assginBtn.Size = new Size(209, 51);
            assginBtn.TabIndex = 6;
            assginBtn.TextAlign = ContentAlignment.MiddleCenter;
            assginBtn.Click += assginBtn_Click;
            // 
            // label2
            // 
            label2.Active = false;
            label2.Activecolor = Color.FromArgb(46, 139, 87);
            label2.BackColor = Color.FromArgb(46, 139, 87);
            label2.BackgroundImageLayout = ImageLayout.Stretch;
            label2.BorderRadius = 0;
            label2.ButtonText = "Description";
            label2.DisabledColor = Color.Gray;
            label2.Iconcolor = Color.FromArgb(0, 0, 192);
            label2.Iconimage = null;
            label2.Iconimage_right = null;
            label2.Iconimage_right_Selected = null;
            label2.Iconimage_Selected = null;
            label2.IconMarginLeft = 0;
            label2.IconMarginRight = 0;
            label2.IconRightVisible = true;
            label2.IconRightZoom = 0D;
            label2.IconVisible = true;
            label2.IconZoom = 90D;
            label2.IsTab = false;
            label2.Location = new Point(4, 236);
            label2.Margin = new Padding(4, 5, 4, 5);
            label2.Name = "label2";
            label2.Normalcolor = Color.FromArgb(46, 139, 87);
            label2.OnHovercolor = Color.FromArgb(36, 129, 77);
            label2.OnHoverTextColor = Color.White;
            label2.selected = false;
            label2.Size = new Size(168, 36);
            label2.TabIndex = 5;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Textcolor = Color.White;
            label2.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // label1
            // 
            label1.Active = false;
            label1.Activecolor = Color.FromArgb(46, 139, 87);
            label1.BackColor = Color.FromArgb(46, 139, 87);
            label1.BackgroundImageLayout = ImageLayout.Stretch;
            label1.BorderRadius = 0;
            label1.ButtonText = "Task Name";
            label1.DisabledColor = Color.Gray;
            label1.Iconcolor = Color.FromArgb(0, 0, 192);
            label1.Iconimage = null;
            label1.Iconimage_right = null;
            label1.Iconimage_right_Selected = null;
            label1.Iconimage_Selected = null;
            label1.IconMarginLeft = 0;
            label1.IconMarginRight = 0;
            label1.IconRightVisible = true;
            label1.IconRightZoom = 0D;
            label1.IconVisible = true;
            label1.IconZoom = 90D;
            label1.IsTab = false;
            label1.Location = new Point(4, 136);
            label1.Margin = new Padding(4, 5, 4, 5);
            label1.Name = "label1";
            label1.Normalcolor = Color.FromArgb(46, 139, 87);
            label1.OnHovercolor = Color.FromArgb(36, 129, 77);
            label1.OnHoverTextColor = Color.White;
            label1.selected = false;
            label1.Size = new Size(164, 40);
            label1.TabIndex = 4;
            label1.Text = "Task Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Textcolor = Color.White;
            label1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // descBx
            // 
            descBx.Location = new Point(0, 280);
            descBx.Multiline = true;
            descBx.Name = "descBx";
            descBx.Size = new Size(347, 34);
            descBx.TabIndex = 3;
            // 
            // tasknameBx
            // 
            tasknameBx.Location = new Point(0, 184);
            tasknameBx.Multiline = true;
            tasknameBx.Name = "tasknameBx";
            tasknameBx.Size = new Size(347, 34);
            tasknameBx.TabIndex = 2;
            // 
            // Button1
            // 
            Button1.Active = false;
            Button1.Activecolor = Color.FromArgb(46, 139, 87);
            Button1.BackColor = Color.FromArgb(46, 139, 87);
            Button1.BackgroundImageLayout = ImageLayout.Stretch;
            Button1.BorderRadius = 0;
            Button1.ButtonText = "Task Assignment";
            Button1.DisabledColor = Color.Gray;
            Button1.Iconcolor = Color.FromArgb(0, 0, 192);
            Button1.Iconimage = null;
            Button1.Iconimage_right = null;
            Button1.Iconimage_right_Selected = null;
            Button1.Iconimage_Selected = null;
            Button1.IconMarginLeft = 0;
            Button1.IconMarginRight = 0;
            Button1.IconRightVisible = true;
            Button1.IconRightZoom = 0D;
            Button1.IconVisible = true;
            Button1.IconZoom = 90D;
            Button1.IsTab = false;
            Button1.Location = new Point(14, 15);
            Button1.Margin = new Padding(4, 5, 4, 5);
            Button1.Name = "Button1";
            Button1.Normalcolor = Color.FromArgb(46, 139, 87);
            Button1.OnHovercolor = Color.FromArgb(36, 129, 77);
            Button1.OnHoverTextColor = Color.White;
            Button1.selected = false;
            Button1.Size = new Size(333, 92);
            Button1.TabIndex = 1;
            Button1.Text = "Task Assignment";
            Button1.TextAlign = ContentAlignment.MiddleCenter;
            Button1.Textcolor = Color.White;
            Button1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // assignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1022);
            Controls.Add(bunifuCards1);
            Name = "assignTask";
            Text = "assignTask";
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 assginBtn;
        private Bunifu.Framework.UI.BunifuFlatButton label2;
        private Bunifu.Framework.UI.BunifuFlatButton label1;
        private TextBox descBx;
        private TextBox tasknameBx;
        private Bunifu.Framework.UI.BunifuFlatButton Button1;
    }
}
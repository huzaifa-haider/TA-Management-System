namespace project1
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            rejectBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            approveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            doneBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            homeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            dataGridView1 = new DataGridView();
            bunifuCards1.SuspendLayout();
            bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            bunifuCards1.Controls.Add(doneBtn);
            bunifuCards1.Controls.Add(homeBtn);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(1732, 12);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(140, 496);
            bunifuCards1.TabIndex = 12;
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
            rejectBtn.Location = new Point(10, 382);
            rejectBtn.Margin = new Padding(5);
            rejectBtn.Name = "rejectBtn";
            rejectBtn.Size = new Size(130, 47);
            rejectBtn.TabIndex = 13;
            rejectBtn.TextAlign = ContentAlignment.MiddleCenter;
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
            approveBtn.Location = new Point(8, 325);
            approveBtn.Margin = new Padding(5);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(130, 47);
            approveBtn.TabIndex = 12;
            approveBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // doneBtn
            // 
            doneBtn.ActiveBorderThickness = 1;
            doneBtn.ActiveCornerRadius = 20;
            doneBtn.ActiveFillColor = Color.SeaGreen;
            doneBtn.ActiveForecolor = Color.Transparent;
            doneBtn.ActiveLineColor = Color.SeaGreen;
            doneBtn.BackColor = Color.White;
            doneBtn.BackgroundImage = (Image)resources.GetObject("doneBtn.BackgroundImage");
            doneBtn.ButtonText = "Mark As Done";
            doneBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doneBtn.ForeColor = Color.SeaGreen;
            doneBtn.IdleBorderThickness = 1;
            doneBtn.IdleCornerRadius = 20;
            doneBtn.IdleFillColor = Color.White;
            doneBtn.IdleForecolor = Color.SeaGreen;
            doneBtn.IdleLineColor = Color.SeaGreen;
            doneBtn.Location = new Point(5, 68);
            doneBtn.Margin = new Padding(5);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(130, 54);
            doneBtn.TabIndex = 10;
            doneBtn.TextAlign = ContentAlignment.MiddleCenter;
            doneBtn.Click += doneBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.ActiveBorderThickness = 1;
            homeBtn.ActiveCornerRadius = 20;
            homeBtn.ActiveFillColor = Color.SeaGreen;
            homeBtn.ActiveForecolor = Color.Transparent;
            homeBtn.ActiveLineColor = Color.SeaGreen;
            homeBtn.BackColor = Color.White;
            homeBtn.BackgroundImage = (Image)resources.GetObject("homeBtn.BackgroundImage");
            homeBtn.ButtonText = "Home";
            homeBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.ForeColor = Color.SeaGreen;
            homeBtn.IdleBorderThickness = 1;
            homeBtn.IdleCornerRadius = 20;
            homeBtn.IdleFillColor = Color.White;
            homeBtn.IdleForecolor = Color.SeaGreen;
            homeBtn.IdleLineColor = Color.SeaGreen;
            homeBtn.Location = new Point(5, 11);
            homeBtn.Margin = new Padding(5);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(130, 47);
            homeBtn.TabIndex = 9;
            homeBtn.TextAlign = ContentAlignment.MiddleCenter;
            homeBtn.Click += homeBtn_Click;
            // 
            // bunifuCards2
            // 
            bunifuCards2.BackColor = SystemColors.ActiveCaption;
            bunifuCards2.BorderRadius = 5;
            bunifuCards2.BottomSahddow = true;
            bunifuCards2.BottomShadow = true;
            bunifuCards2.color = Color.Tomato;
            bunifuCards2.Controls.Add(dataGridView1);
            bunifuCards2.IndicatorColor = Color.Tomato;
            bunifuCards2.LeftSahddow = false;
            bunifuCards2.LeftShadow = false;
            bunifuCards2.Location = new Point(44, 35);
            bunifuCards2.Name = "bunifuCards2";
            bunifuCards2.RightSahddow = true;
            bunifuCards2.RightShadow = true;
            bunifuCards2.ShadowDepth = 20;
            bunifuCards2.Size = new Size(879, 332);
            bunifuCards2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(854, 306);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 986);
            Controls.Add(bunifuCards2);
            Controls.Add(bunifuCards1);
            Name = "Task";
            Text = "Task";
            bunifuCards1.ResumeLayout(false);
            bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 rejectBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 approveBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 doneBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 homeBtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private DataGridView dataGridView1;
    }
}
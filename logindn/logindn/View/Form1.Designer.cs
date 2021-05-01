
namespace logindn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.dangKy1 = new logindn.DangKy();
            this.lg1 = new logindn.LG();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_signup
            // 
            this.linkLabel_signup.AutoSize = true;
            this.linkLabel_signup.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.linkLabel_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_signup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_signup.Location = new System.Drawing.Point(567, 417);
            this.linkLabel_signup.Name = "linkLabel_signup";
            this.linkLabel_signup.Size = new System.Drawing.Size(88, 13);
            this.linkLabel_signup.TabIndex = 8;
            this.linkLabel_signup.TabStop = true;
            this.linkLabel_signup.Text = "Đăng Ký Ngay";
            this.linkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signup_LinkClicked);
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.AutoSize = true;
            this.linkLabel_login.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_login.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_login.Location = new System.Drawing.Point(495, 476);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(71, 13);
            this.linkLabel_login.TabIndex = 26;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Đăng Nhập";
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // dangKy1
            // 
            this.dangKy1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dangKy1.Location = new System.Drawing.Point(383, 84);
            this.dangKy1.Name = "dangKy1";
            this.dangKy1.Size = new System.Drawing.Size(293, 414);
            this.dangKy1.TabIndex = 9;
            this.dangKy1.VisibleChanged += new System.EventHandler(this.dangKy1_VisibleChanged);
            // 
            // lg1
            // 
            this.lg1.BackColor = System.Drawing.Color.Silver;
            this.lg1.Location = new System.Drawing.Point(383, 151);
            this.lg1.Margin = new System.Windows.Forms.Padding(2);
            this.lg1.Name = "lg1";
            this.lg1.Password = "";
            this.lg1.Phone = "";
            this.lg1.Size = new System.Drawing.Size(293, 293);
            this.lg1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 59);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(996, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 60);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng Nhập";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-95, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(333, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.dangKy1);
            this.Controls.Add(this.linkLabel_signup);
            this.Controls.Add(this.lg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LG lg1;
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private DangKy dangKy1;
        private System.Windows.Forms.LinkLabel linkLabel_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


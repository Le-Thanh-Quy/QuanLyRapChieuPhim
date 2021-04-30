
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.dangKy1 = new logindn.DangKy();
            this.lg1 = new logindn.LG();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 661);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.dangKy1);
            this.Controls.Add(this.linkLabel_signup);
            this.Controls.Add(this.lg1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LG lg1;
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private DangKy dangKy1;
        private System.Windows.Forms.LinkLabel linkLabel_login;
    }
}


namespace logindn
{
    partial class DangKy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Login = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(199, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(151, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "hoặc sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Đăng Ký";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Phone.Location = new System.Drawing.Point(57, 99);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(187, 21);
            this.textBox_Phone.TabIndex = 14;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            this.textBox_Phone.Enter += new System.EventHandler(this.textBox_Phone_Enter);
            this.textBox_Phone.Leave += new System.EventHandler(this.textBox_Phone_Leave);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Name.Location = new System.Drawing.Point(57, 59);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(187, 21);
            this.textBox_Name.TabIndex = 13;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            this.textBox_Name.Enter += new System.EventHandler(this.textBox_Name_Enter);
            this.textBox_Name.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Enter += new System.EventHandler(this.dateTimePicker1_Enter);
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPass2.Location = new System.Drawing.Point(57, 230);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(187, 21);
            this.textBoxPass2.TabIndex = 24;
            this.textBoxPass2.TextChanged += new System.EventHandler(this.textBoxPass2_TextChanged);
            this.textBoxPass2.Enter += new System.EventHandler(this.textBoxPass2_Enter);
            this.textBoxPass2.Leave += new System.EventHandler(this.textBoxPass2_Leave);
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPass1.Location = new System.Drawing.Point(57, 190);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(187, 21);
            this.textBoxPass1.TabIndex = 23;
            this.textBoxPass1.TextChanged += new System.EventHandler(this.textBoxPass1_TextChanged);
            this.textBoxPass1.Enter += new System.EventHandler(this.textBoxPass1_Enter);
            this.textBoxPass1.Leave += new System.EventHandler(this.textBoxPass1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày sinh";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Navy;
            this.button_Login.BorderColor = System.Drawing.Color.Silver;
            this.button_Login.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Login.Location = new System.Drawing.Point(57, 269);
            this.button_Login.Name = "button_Login";
            this.button_Login.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_Login.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_Login.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_Login.Size = new System.Drawing.Size(187, 35);
            this.button_Login.TabIndex = 12;
            this.button_Login.Text = "Đăng Ký";
            this.button_Login.TextColor = System.Drawing.Color.Navy;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Login);
            this.Name = "DangKy";
            this.Size = new System.Drawing.Size(294, 390);
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private ePOSOne.btnProduct.Button_WOC button_Login;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.Label label3;
    }
}

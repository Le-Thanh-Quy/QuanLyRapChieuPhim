namespace logindn.View
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLịchChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.textBoxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewThongKe = new System.Windows.Forms.DataGridView();
            this.comboBoxPhim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panelThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhimToolStripMenuItem,
            this.quảnLýLịchChiếuToolStripMenuItem,
            this.quảnLýPhòngChiếuToolStripMenuItem,
            this.quảnLýVéToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýPhimToolStripMenuItem
            // 
            this.quảnLýPhimToolStripMenuItem.Name = "quảnLýPhimToolStripMenuItem";
            this.quảnLýPhimToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.quảnLýPhimToolStripMenuItem.Text = "Quản lý phim";
            this.quảnLýPhimToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhimToolStripMenuItem_Click);
            // 
            // quảnLýLịchChiếuToolStripMenuItem
            // 
            this.quảnLýLịchChiếuToolStripMenuItem.Name = "quảnLýLịchChiếuToolStripMenuItem";
            this.quảnLýLịchChiếuToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quảnLýLịchChiếuToolStripMenuItem.Text = "Quản lý lịch chiếu";
            this.quảnLýLịchChiếuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLịchChiếuToolStripMenuItem_Click);
            // 
            // quảnLýPhòngChiếuToolStripMenuItem
            // 
            this.quảnLýPhòngChiếuToolStripMenuItem.Name = "quảnLýPhòngChiếuToolStripMenuItem";
            this.quảnLýPhòngChiếuToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.quảnLýPhòngChiếuToolStripMenuItem.Text = "Quản lý phòng chiếu";
            this.quảnLýPhòngChiếuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngChiếuToolStripMenuItem_Click);
            // 
            // quảnLýVéToolStripMenuItem
            // 
            this.quảnLýVéToolStripMenuItem.Name = "quảnLýVéToolStripMenuItem";
            this.quảnLýVéToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.quảnLýVéToolStripMenuItem.Text = "Quản lý vé";
            this.quảnLýVéToolStripMenuItem.Click += new System.EventHandler(this.quảnLýVéToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.panelThongKe);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 24);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(881, 416);
            this.panelView.TabIndex = 5;
            // 
            // panelThongKe
            // 
            this.panelThongKe.Controls.Add(this.bunifuLabel2);
            this.panelThongKe.Controls.Add(this.label4);
            this.panelThongKe.Controls.Add(this.label3);
            this.panelThongKe.Controls.Add(this.label2);
            this.panelThongKe.Controls.Add(this.buttonThongKe);
            this.panelThongKe.Controls.Add(this.dateTimePickerKT);
            this.panelThongKe.Controls.Add(this.textBoxTongDoanhThu);
            this.panelThongKe.Controls.Add(this.dateTimePickerBD);
            this.panelThongKe.Controls.Add(this.dataGridViewThongKe);
            this.panelThongKe.Controls.Add(this.comboBoxPhim);
            this.panelThongKe.Controls.Add(this.label1);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongKe.Location = new System.Drawing.Point(0, 0);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(881, 416);
            this.panelThongKe.TabIndex = 0;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuLabel2.Location = new System.Drawing.Point(292, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(299, 37);
            this.bunifuLabel2.TabIndex = 11;
            this.bunifuLabel2.Text = "Thống Kê Doanh Thu";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ ngày";
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Location = new System.Drawing.Point(643, 150);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(75, 23);
            this.buttonThongKe.TabIndex = 7;
            this.buttonThongKe.Text = "Thống Kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKT.Location = new System.Drawing.Point(365, 149);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKT.TabIndex = 6;
            this.dateTimePickerKT.ValueChanged += new System.EventHandler(this.dateTimePickerKT_ValueChanged);
            // 
            // textBoxTongDoanhThu
            // 
            this.textBoxTongDoanhThu.Enabled = false;
            this.textBoxTongDoanhThu.Location = new System.Drawing.Point(544, 376);
            this.textBoxTongDoanhThu.Name = "textBoxTongDoanhThu";
            this.textBoxTongDoanhThu.Size = new System.Drawing.Size(174, 20);
            this.textBoxTongDoanhThu.TabIndex = 5;
            this.textBoxTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBD.Location = new System.Drawing.Point(139, 149);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBD.TabIndex = 4;
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe.Location = new System.Drawing.Point(139, 179);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.ReadOnly = true;
            this.dataGridViewThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongKe.Size = new System.Drawing.Size(579, 191);
            this.dataGridViewThongKe.TabIndex = 3;
            // 
            // comboBoxPhim
            // 
            this.comboBoxPhim.FormattingEnabled = true;
            this.comboBoxPhim.Location = new System.Drawing.Point(223, 82);
            this.comboBoxPhim.Name = "comboBoxPhim";
            this.comboBoxPhim.Size = new System.Drawing.Size(244, 21);
            this.comboBoxPhim.TabIndex = 2;
            this.comboBoxPhim.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Phim";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 440);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelThongKe.ResumeLayout(false);
            this.panelThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelThongKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.TextBox textBoxTongDoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.ComboBox comboBoxPhim;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}
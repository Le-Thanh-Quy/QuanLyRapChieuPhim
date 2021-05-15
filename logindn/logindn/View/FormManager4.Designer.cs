namespace logindn.View
{
    partial class FormManager4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager4));
            this.dataGridViewVe = new System.Windows.Forms.DataGridView();
            this.Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.buttonGia = new System.Windows.Forms.Button();
            this.labelLoaiVe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVe
            // 
            this.dataGridViewVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVe.Location = new System.Drawing.Point(215, 64);
            this.dataGridViewVe.Name = "dataGridViewVe";
            this.dataGridViewVe.ReadOnly = true;
            this.dataGridViewVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVe.Size = new System.Drawing.Size(441, 197);
            this.dataGridViewVe.TabIndex = 0;
            this.dataGridViewVe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVe_CellDoubleClick);
            // 
            // Label
            // 
            this.Label.AllowParentOverrides = false;
            this.Label.AutoEllipsis = false;
            this.Label.AutoSize = false;
            this.Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label.CursorType = System.Windows.Forms.Cursors.Default;
            this.Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label.Location = new System.Drawing.Point(291, 12);
            this.Label.Name = "Label";
            this.Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label.Size = new System.Drawing.Size(299, 37);
            this.Label.TabIndex = 4;
            this.Label.Text = "Quản Lý Giá Vé";
            this.Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(291, 313);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(174, 20);
            this.textBoxGia.TabIndex = 5;
            this.textBoxGia.TextChanged += new System.EventHandler(this.textBoxGia_TextChanged);
            this.textBoxGia.Enter += new System.EventHandler(this.textBoxGia_Enter);
            this.textBoxGia.Leave += new System.EventHandler(this.textBoxGia_Leave);
            // 
            // buttonGia
            // 
            this.buttonGia.Location = new System.Drawing.Point(484, 310);
            this.buttonGia.Name = "buttonGia";
            this.buttonGia.Size = new System.Drawing.Size(75, 23);
            this.buttonGia.TabIndex = 6;
            this.buttonGia.Text = "Cập Nhật";
            this.buttonGia.UseVisualStyleBackColor = true;
            this.buttonGia.Click += new System.EventHandler(this.buttonGia_Click);
            // 
            // labelLoaiVe
            // 
            this.labelLoaiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiVe.Location = new System.Drawing.Point(354, 273);
            this.labelLoaiVe.Name = "labelLoaiVe";
            this.labelLoaiVe.Size = new System.Drawing.Size(167, 23);
            this.labelLoaiVe.TabIndex = 7;
            this.labelLoaiVe.Text = "Vé học sinh-sinh viên";
            this.labelLoaiVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormManager4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 374);
            this.Controls.Add(this.labelLoaiVe);
            this.Controls.Add(this.buttonGia);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.dataGridViewVe);
            this.Name = "FormManager4";
            this.Text = "FormManager4";
            this.Load += new System.EventHandler(this.FormManager4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVe;
        private Bunifu.UI.WinForms.BunifuLabel Label;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Button buttonGia;
        private System.Windows.Forms.Label labelLoaiVe;
    }
}
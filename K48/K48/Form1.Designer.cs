namespace K48
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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoLop = new System.Windows.Forms.RadioButton();
            this.rdoSV = new System.Windows.Forms.RadioButton();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(12, 135);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(559, 283);
            this.dgvKhoa.TabIndex = 0;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(12, 12);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(50, 17);
            this.rdoKhoa.TabIndex = 1;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "Khoa";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoLop
            // 
            this.rdoLop.AutoSize = true;
            this.rdoLop.Location = new System.Drawing.Point(12, 35);
            this.rdoLop.Name = "rdoLop";
            this.rdoLop.Size = new System.Drawing.Size(43, 17);
            this.rdoLop.TabIndex = 2;
            this.rdoLop.TabStop = true;
            this.rdoLop.Text = "Lớp";
            this.rdoLop.UseVisualStyleBackColor = true;
            // 
            // rdoSV
            // 
            this.rdoSV.AutoSize = true;
            this.rdoSV.Location = new System.Drawing.Point(12, 58);
            this.rdoSV.Name = "rdoSV";
            this.rdoSV.Size = new System.Drawing.Size(39, 17);
            this.rdoSV.TabIndex = 3;
            this.rdoSV.TabStop = true;
            this.rdoSV.Text = "SV";
            this.rdoSV.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHienthi.Location = new System.Drawing.Point(417, 10);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 4;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click_1);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(63, 12);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(170, 21);
            this.cboKhoa.TabIndex = 5;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(239, 11);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(172, 21);
            this.cboLop.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.rdoSV);
            this.Controls.Add(this.rdoLop);
            this.Controls.Add(this.rdoKhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K48";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoLop;
        private System.Windows.Forms.RadioButton rdoSV;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ComboBox cboLop;

    }
}


namespace Form1
{
    partial class QuenMK
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reMK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.btn_Dn = new System.Windows.Forms.Button();
            this.btn_Kiemtra = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_LayMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mật khẩu mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Số ĐT đăng ký:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_reMK
            // 
            this.txt_reMK.Location = new System.Drawing.Point(179, 129);
            this.txt_reMK.Name = "txt_reMK";
            this.txt_reMK.PasswordChar = '*';
            this.txt_reMK.Size = new System.Drawing.Size(230, 30);
            this.txt_reMK.TabIndex = 3;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(179, 93);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(230, 30);
            this.txt_MK.TabIndex = 2;
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(179, 20);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(230, 30);
            this.txt_TenDN.TabIndex = 0;
            this.txt_TenDN.TextChanged += new System.EventHandler(this.txt_TenDN_TextChanged);
            // 
            // btn_Dn
            // 
            this.btn_Dn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Dn.Location = new System.Drawing.Point(308, 191);
            this.btn_Dn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dn.Name = "btn_Dn";
            this.btn_Dn.Size = new System.Drawing.Size(101, 32);
            this.btn_Dn.TabIndex = 6;
            this.btn_Dn.Text = "Đăng nhập";
            this.btn_Dn.UseVisualStyleBackColor = false;
            this.btn_Dn.Click += new System.EventHandler(this.btn_Dn_Click);
            // 
            // btn_Kiemtra
            // 
            this.btn_Kiemtra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Kiemtra.Location = new System.Drawing.Point(36, 191);
            this.btn_Kiemtra.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kiemtra.Name = "btn_Kiemtra";
            this.btn_Kiemtra.Size = new System.Drawing.Size(103, 32);
            this.btn_Kiemtra.TabIndex = 4;
            this.btn_Kiemtra.Text = "Kiểm tra";
            this.btn_Kiemtra.UseVisualStyleBackColor = false;
            this.btn_Kiemtra.Click += new System.EventHandler(this.btn_Kiemtra_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(179, 56);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '*';
            this.txt_SDT.Size = new System.Drawing.Size(230, 30);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // btn_LayMK
            // 
            this.btn_LayMK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LayMK.Location = new System.Drawing.Point(161, 191);
            this.btn_LayMK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LayMK.Name = "btn_LayMK";
            this.btn_LayMK.Size = new System.Drawing.Size(127, 32);
            this.btn_LayMK.TabIndex = 5;
            this.btn_LayMK.Text = "Lấy mật khảu";
            this.btn_LayMK.UseVisualStyleBackColor = false;
            this.btn_LayMK.Click += new System.EventHandler(this.btn_LayMK_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 236);
            this.Controls.Add(this.btn_LayMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_reMK);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.btn_Dn);
            this.Controls.Add(this.btn_Kiemtra);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_reMK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Button btn_Dn;
        private System.Windows.Forms.Button btn_Kiemtra;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button btn_LayMK;
    }
}
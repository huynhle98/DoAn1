namespace Form1
{
    partial class FormDK
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TaoTK = new System.Windows.Forms.Button();
            this.btn_Kiemtra = new System.Windows.Forms.Button();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số ĐT đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(170, 130);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '*';
            this.txt_SDT.Size = new System.Drawing.Size(230, 30);
            this.txt_SDT.TabIndex = 3;
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(170, 22);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(230, 30);
            this.txt_TenDN.TabIndex = 0;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(170, 94);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(230, 30);
            this.txt_MK.TabIndex = 2;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(170, 58);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(230, 30);
            this.txt_TenNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tên nhân vật:";
            // 
            // btn_TaoTK
            // 
            this.btn_TaoTK.Location = new System.Drawing.Point(150, 193);
            this.btn_TaoTK.Name = "btn_TaoTK";
            this.btn_TaoTK.Size = new System.Drawing.Size(134, 31);
            this.btn_TaoTK.TabIndex = 5;
            this.btn_TaoTK.Text = "Tạo tài khoản";
            this.btn_TaoTK.UseVisualStyleBackColor = true;
            this.btn_TaoTK.Click += new System.EventHandler(this.btn_TaoTK_Click);
            // 
            // btn_Kiemtra
            // 
            this.btn_Kiemtra.Location = new System.Drawing.Point(29, 193);
            this.btn_Kiemtra.Name = "btn_Kiemtra";
            this.btn_Kiemtra.Size = new System.Drawing.Size(105, 31);
            this.btn_Kiemtra.TabIndex = 4;
            this.btn_Kiemtra.Text = "Kiểm tra";
            this.btn_Kiemtra.UseVisualStyleBackColor = true;
            this.btn_Kiemtra.Click += new System.EventHandler(this.btn_Kiemtra_Click);
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.Location = new System.Drawing.Point(302, 193);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(110, 31);
            this.btn_Quaylai.TabIndex = 6;
            this.btn_Quaylai.Text = "Quay lại";
            this.btn_Quaylai.UseVisualStyleBackColor = true;
            this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // FormDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 236);
            this.Controls.Add(this.btn_Kiemtra);
            this.Controls.Add(this.btn_Quaylai);
            this.Controls.Add(this.btn_TaoTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenDN);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDK";
            this.Load += new System.EventHandler(this.FormDK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_TaoTK;
        private System.Windows.Forms.Button btn_Kiemtra;
        private System.Windows.Forms.Button btn_Quaylai;
    }
}
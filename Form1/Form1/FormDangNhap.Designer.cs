namespace Form1
{
    partial class FormDangNhap
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
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_QuenMK = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(193, 17);
            this.txt_TenDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(190, 34);
            this.txt_TenDN.TabIndex = 0;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(193, 73);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(190, 34);
            this.txt_MK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_DN
            // 
            this.btn_DN.Location = new System.Drawing.Point(147, 114);
            this.btn_DN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(142, 37);
            this.btn_DN.TabIndex = 2;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_QuenMK
            // 
            this.btn_QuenMK.Location = new System.Drawing.Point(28, 176);
            this.btn_QuenMK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuenMK.Name = "btn_QuenMK";
            this.btn_QuenMK.Size = new System.Drawing.Size(185, 37);
            this.btn_QuenMK.TabIndex = 3;
            this.btn_QuenMK.Text = "Quên mật khẩu";
            this.btn_QuenMK.UseVisualStyleBackColor = true;
            this.btn_QuenMK.Click += new System.EventHandler(this.btn_QuenMK_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(226, 176);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(185, 37);
            this.btn_QuayLai.TabIndex = 4;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 236);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_QuenMK);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenDN);
            this.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_QuenMK;
        private System.Windows.Forms.Button btn_QuayLai;
    }
}
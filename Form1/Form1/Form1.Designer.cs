namespace Form1
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
            this.btn_ChoiThu = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ChoiThu
            // 
            this.btn_ChoiThu.BackColor = System.Drawing.Color.White;
            this.btn_ChoiThu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ChoiThu.Location = new System.Drawing.Point(144, 188);
            this.btn_ChoiThu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ChoiThu.Name = "btn_ChoiThu";
            this.btn_ChoiThu.Size = new System.Drawing.Size(157, 48);
            this.btn_ChoiThu.TabIndex = 0;
            this.btn_ChoiThu.Text = "Chơi thử";
            this.btn_ChoiThu.UseVisualStyleBackColor = false;
            this.btn_ChoiThu.Click += new System.EventHandler(this.btn_ChoiThu_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.White;
            this.btn_DangNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_DangNhap.Location = new System.Drawing.Point(144, 260);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(157, 48);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.White;
            this.btn_DangKy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_DangKy.Location = new System.Drawing.Point(144, 329);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(157, 48);
            this.btn_DangKy.TabIndex = 0;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(144, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stack Jump (ver Titans)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_ChoiThu);
            this.Font = new System.Drawing.Font("Segoe Print", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChoiThu;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


namespace Form1
{
    partial class GamePlay
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel_CN = new System.Windows.Forms.Panel();
            this.label_Diem = new System.Windows.Forms.Label();
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelBST = new System.Windows.Forms.Label();
            this.labelBXH = new System.Windows.Forms.Label();
            this.labelThoat = new System.Windows.Forms.Label();
            this.timerCreateBlock = new System.Windows.Forms.Timer(this.components);
            this.TimerJump = new System.Windows.Forms.Timer(this.components);
            this.timerRunKhung = new System.Windows.Forms.Timer(this.components);
            this.tm_zoom = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel_CN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.labelThoat);
            this.panelMenu.Controls.Add(this.labelBXH);
            this.panelMenu.Controls.Add(this.labelBST);
            this.panelMenu.Controls.Add(this.labelPlay);
            this.panelMenu.Location = new System.Drawing.Point(76, 243);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(296, 201);
            this.panelMenu.TabIndex = 5;
            // 
            // panel_CN
            // 
            this.panel_CN.BackColor = System.Drawing.Color.Transparent;
            this.panel_CN.Controls.Add(this.label_Diem);
            this.panel_CN.Location = new System.Drawing.Point(-4, -2);
            this.panel_CN.Name = "panel_CN";
            this.panel_CN.Size = new System.Drawing.Size(435, 50);
            this.panel_CN.TabIndex = 6;
            // 
            // label_Diem
            // 
            this.label_Diem.AutoSize = true;
            this.label_Diem.BackColor = System.Drawing.Color.Transparent;
            this.label_Diem.ForeColor = System.Drawing.Color.White;
            this.label_Diem.Location = new System.Drawing.Point(205, 11);
            this.label_Diem.Name = "label_Diem";
            this.label_Diem.Size = new System.Drawing.Size(33, 37);
            this.label_Diem.TabIndex = 0;
            this.label_Diem.Text = "0";
            this.label_Diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlay
            // 
            this.labelPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.ForeColor = System.Drawing.Color.White;
            this.labelPlay.Location = new System.Drawing.Point(60, 40);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(179, 41);
            this.labelPlay.TabIndex = 0;
            this.labelPlay.Text = "Tap To Play";
            this.labelPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            // 
            // labelBST
            // 
            this.labelBST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBST.AutoSize = true;
            this.labelBST.BackColor = System.Drawing.Color.Transparent;
            this.labelBST.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBST.ForeColor = System.Drawing.Color.White;
            this.labelBST.Location = new System.Drawing.Point(22, 110);
            this.labelBST.Name = "labelBST";
            this.labelBST.Size = new System.Drawing.Size(91, 22);
            this.labelBST.TabIndex = 0;
            this.labelBST.Text = "Bộ sưu tập";
            this.labelBST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBST.Click += new System.EventHandler(this.labelBST_Click);
            // 
            // labelBXH
            // 
            this.labelBXH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBXH.AutoSize = true;
            this.labelBXH.BackColor = System.Drawing.Color.Transparent;
            this.labelBXH.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBXH.ForeColor = System.Drawing.Color.White;
            this.labelBXH.Location = new System.Drawing.Point(153, 110);
            this.labelBXH.Name = "labelBXH";
            this.labelBXH.Size = new System.Drawing.Size(124, 22);
            this.labelBXH.TabIndex = 0;
            this.labelBXH.Text = "Bảng xếp hạng";
            this.labelBXH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBXH.Click += new System.EventHandler(this.labelBXH_Click);
            // 
            // labelThoat
            // 
            this.labelThoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThoat.AutoSize = true;
            this.labelThoat.BackColor = System.Drawing.Color.Transparent;
            this.labelThoat.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoat.ForeColor = System.Drawing.Color.White;
            this.labelThoat.Location = new System.Drawing.Point(108, 148);
            this.labelThoat.Name = "labelThoat";
            this.labelThoat.Size = new System.Drawing.Size(61, 25);
            this.labelThoat.TabIndex = 0;
            this.labelThoat.Text = "Thoát";
            this.labelThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThoat.Click += new System.EventHandler(this.labelThoat_Click);
            // 
            // timerCreateBlock
            // 
            this.timerCreateBlock.Tick += new System.EventHandler(this.timerCreateBlock_Tick);
            // 
            // TimerJump
            // 
            this.TimerJump.Interval = 30;
            this.TimerJump.Tick += new System.EventHandler(this.TimerJump_Tick);
            // 
            // timerRunKhung
            // 
            this.timerRunKhung.Interval = 10;
            this.timerRunKhung.Tick += new System.EventHandler(this.timerRunKhung_Tick);
            // 
            // tm_zoom
            // 
            this.tm_zoom.Tick += new System.EventHandler(this.tm_zoom_Tick);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Form1.Properties.Resources.gameplay1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 620);
            this.Controls.Add(this.panel_CN);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe Script", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "GamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel_CN.ResumeLayout(false);
            this.panel_CN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel_CN;
        private System.Windows.Forms.Label label_Diem;
        private System.Windows.Forms.Label labelThoat;
        private System.Windows.Forms.Label labelBXH;
        private System.Windows.Forms.Label labelBST;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Timer timerCreateBlock;
        private System.Windows.Forms.Timer TimerJump;
        private System.Windows.Forms.Timer timerRunKhung;
        private System.Windows.Forms.Timer tm_zoom;
    }
}
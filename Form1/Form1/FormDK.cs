using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1.Layer;

namespace Form1
{
    public partial class FormDK : Form
    {
        string err;
        BLDangNhap dn = new BLDangNhap();

        public FormDK()
        {
            InitializeComponent();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Kiemtra_Click(object sender, EventArgs e)
        {
            if (txt_TenDN.Text != "" && txt_TenNV.Text != "")
            {
                if (dn.KiemtraTKDK(txt_TenDN.Text, txt_TenNV.Text, ref err) == 0)
                {
                    MessageBox.Show("Bạn có thể sử dụng tên tài khoản và tên nhân vật này.");
                    this.txt_MK.Enabled = true;                   
                    this.txt_TenDN.Enabled = false;
                    this.txt_TenNV.Enabled = false;                
                    this.txt_SDT.Enabled = true;

                    this.btn_TaoTK.Enabled = true;
                    this.btn_Kiemtra.Enabled = false;
                }
                if (dn.KiemtraTKDK(txt_TenDN.Text, txt_TenNV.Text, ref err) == 1)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại !!!");
                }
                if (dn.KiemtraTKDK(txt_TenDN.Text, txt_TenNV.Text, ref err) == 2)
                {
                    MessageBox.Show("Tên nhân vật đã tồn tại !!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập và tên nhân vật!!!");
            }
        }

        void load()
        {
            this.txt_MK.Enabled = false;
            this.txt_TenDN.Enabled = true;
            this.txt_SDT.Enabled = false; ;
            this.txt_TenNV.Enabled = true;
            this.btn_TaoTK.Enabled = false;
            this.btn_Quaylai.Enabled = true;
            this.btn_Kiemtra.Enabled = true;
    
        }

        private void FormDK_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_TaoTK_Click(object sender, EventArgs e)
        {
            //try
            {
                BLDangNhap tk = new BLDangNhap();
                tk.ThemTK(txt_TenDN.Text, txt_TenNV.Text, txt_MK.Text, txt_SDT.Text, ref err);
                MessageBox.Show("Tạo tài khoản thành công");
            }
            //catch
            //{
            //    MessageBox.Show("Không thêm được!!");
            //}
        }
    }
}

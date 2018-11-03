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
    public partial class QuenMK : Form
    {
        string err;
        BLDangNhap dn=new BLDangNhap();
        
        public QuenMK()
        {
            InitializeComponent();
        }
        void load()
        {
            this.txt_MK.Enabled = false;
            this.txt_reMK.Enabled = false;
            this.btn_LayMK.Enabled = false;
            this.btn_Kiemtra.Enabled = true;
            this.txt_TenDN.Enabled = true;
            this.txt_SDT.Enabled = true;
        }
        void reset()
        {
            this.txt_SDT.ResetText();
            this.txt_MK.ResetText();
            this.txt_reMK.ResetText();
            this.txt_TenDN.ResetText();
        }

        private void btn_Dn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void btn_Kiemtra_Click(object sender, EventArgs e)
        {
            if (txt_TenDN.Text != "" && txt_SDT.Text != "")
            {
                if (dn.KiemtraTK(txt_TenDN.Text, txt_SDT.Text, ref err) == true)
                {
                    MessageBox.Show("Hãy nhập mật Khẩu mới.");
                    this.txt_MK.Enabled = true;
                    this.txt_reMK.Enabled = true;
                    this.btn_LayMK.Enabled = true;
                    this.btn_Kiemtra.Enabled = false;
                    this.txt_TenDN.Enabled = false;
                    this.txt_SDT.Enabled = false;
                }
                if (dn.KiemtraTK(txt_TenDN.Text, txt_SDT.Text, ref err) == false)
                {
                    MessageBox.Show("Tên tài khoản hoặc số điện thoại đăng ký không đúng!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập và số điện thoại đăng ký!!!");
            }
        }

        private void btn_LayMK_Click(object sender, EventArgs e)
        {
            this.txt_TenDN.Enabled = false;
            this.txt_SDT.Enabled = false;
            if (txt_MK.Text != "" && txt_reMK.Text != "")
            {
                if (txt_MK.Text == txt_reMK.Text)
                {
                    dn.LayMK(txt_TenDN.Text, txt_MK.Text, ref err);
                    MessageBox.Show("Lấy lại mật khẩu thành công");
                    load();
                    reset();
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không đúng!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và nhập lại mật khẩu mới!!!");
            }
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {
            load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

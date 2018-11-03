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
    public partial class FormDangNhap : Form
    {
        string err;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            BLDangNhap tk = new BLDangNhap();
            if (txt_TenDN.Text != "" && txt_MK.Text != "")
            {

                if (tk.KiemTra(this.txt_TenDN.Text, this.txt_MK.Text, ref err) == true)
                {
                    this.Close();
                    GamePlay f = new GamePlay();
                    f.Show();
                    this.txt_TenDN.ResetText();
                    this.txt_MK.ResetText();
                    Form1.tGamePlay = true;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!");
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuenMK_Click(object sender, EventArgs e)
        {
            this.Close();
            QuenMK f = new QuenMK();
            f.Show();
        }
    }
}

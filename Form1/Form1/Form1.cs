using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public static bool tGamePlay;
        public static int tForm = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Form2 f = new Form2();
            f.FormClosed += new FormClosedEventHandler(f_Closed);
            f.Show();
            */
            
        }
        
        private void f_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePlay f = new GamePlay();
            f.Show();
        }

        private void btn_ChoiThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePlay f = new GamePlay();
            f.Show();
            tGamePlay = false;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {           
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            FormDK f = new FormDK();
            f.Show();
        }
    }
}

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
    public partial class GamePlay : Form
    {
        int Diem = 0;
        bool TaoKhung = true;
        bool AllowJump = true;
        int zoomTick = 0;
        bool newgame = false;
        public static Point p = new Point(-200, 400);
        Khung Block;
        NhanVat Character = new NhanVat();
        List<Khung> Khungs = new List<Khung>();

        public GamePlay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.tForm = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.tForm = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.tForm = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panelMenu.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void labelThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelBST_Click(object sender, EventArgs e)
        {

        }

        private void labelBXH_Click(object sender, EventArgs e)
        {

        }

        private void labelPlay_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            panelMenu.Hide();
            
            timerCreateBlock.Start();

            //GamePlay f = new GamePlay();
        }
        private void timerCreateBlock_Tick(object sender, EventArgs e)
        {
            if (TaoKhung)
            {
                AllowJump = true;
                Block = new Khung();
                Block.TaoKhung(this);
                Khungs.Add(Block);
                timerRunKhung.Start();
                
            }
            //    timerCreateBlock.Stop();
            TaoKhung = false;
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TimerJump.Start();
            }
        }

        private void TimerJump_Tick(object sender, EventArgs e)
        {
            Character.Jump();

            if (Character.Jumped == true)//neu da jump roi thi tat timer
            {
                //if(AllowJump)
                //    Character.PicNhanVat.Top -= 40;
                TimerJump.Stop();
                AllowJump = false;
            }

        }

        private void timerRunKhung_Tick(object sender, EventArgs e)
        {
            Block.RunKhung();
            if (ChamPhaiBlock(Khungs[Khungs.Count - 1].Pbox))
            {
                TaoKhung = false;
                AllowJump = false;
                timerRunKhung.Stop();
                MessageBox.Show("Game over");
                panelMenu.Show();
                //tm_zoom.Start();

                GamePlay f = new GamePlay();
                f.Show();
            }

            if (ChamTrenBlock(Khungs[Khungs.Count - 1].Pbox))
            {
                TaoKhung = true;
                AllowJump = true;
                foreach (Khung khung in Khungs)
                {
                    khung.Pbox.Top += 40;
                }
                Diem += 10;
                label_Diem.Text = Diem.ToString();
            }

            //   timerRunDown.Stop();
        }

        public bool ChamTrenBlock(PictureBox PicBlock)
        {
            if (PicBlock.Bounds.IntersectsWith(Character.PicNhanVat.Bounds))
            {
                if (PicBlock.Location.Y - 40 >= Character.PicNhanVat.Location.Y)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }
        public bool ChamPhaiBlock(PictureBox PicBlock)
        {
            if (PicBlock.Bounds.IntersectsWith(Character.PicNhanVat.Bounds))
            {
                if (PicBlock.Location.Y - PicBlock.Height < Character.PicNhanVat.Location.Y)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void tm_zoom_Tick(object sender, EventArgs e)
        {
            if (zoomTick < 20)
            {
                foreach (Control i in this.Controls)
                {
                    if (i.Tag != "NV")
                        i.Left++;
                    i.Size = new Size(i.Width - 1, i.Height - 1);
                }
                zoomTick++;
            }
            else
                tm_zoom.Stop();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            Character.CreateNV(this);
        }
    }
}

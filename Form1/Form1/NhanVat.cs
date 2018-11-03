using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Form1
{
    class NhanVat
    {
        public PictureBox PicNhanVat;
        public bool Up = true;
        public bool Jumped = false;
        private int t = 147, s = 147;

        public PictureBox pNhanVat
        {
            get
            {
                return this.PicNhanVat;
            }
            set
            {
                this.PicNhanVat = value;
            }
        }

        public NhanVat()
        { }

        public void CreateNV(Form f)
        {
            PicNhanVat = new PictureBox();
            PicNhanVat.Location = new Point(230, 380);
            PicNhanVat.Size = new Size(40, 60);
            PicNhanVat.BackColor = Color.Red;
            PicNhanVat.Tag = "NV";
            f.Controls.Add(PicNhanVat);
        }

        public void Jump()
        {
            Jumped = false;
            if (Up)//bay len
            {
                if (t != 0)
                {
                    this.pNhanVat.Top -= 21;
                    t -= 21;
                }
                else
                {
                    Up = false;
                }
            }
            else//bay xuong
            {
                if (s != 0)
                {
                    this.pNhanVat.Top += 21;
                    s -= 21;
                }
                else
                {
                    Up = true;
                    t = 147;
                    s = 147;
                    Jumped = true;//da jump xong 

                }
            }
        }
    }
}

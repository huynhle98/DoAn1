using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Form1
{
    class Khung
    {
        private Form f;
        public PictureBox Pbox;
        private Point pLocation;
        public Form F
        {
            get
            {
                return this.f;
            }
            set
            {
                this.f = value;
            }
        }
        public PictureBox pBox
        {
            get
            {
                return this.Pbox;
            }
            set
            {
                this.Pbox = value;
            }
        }
        public Point p
        {
            get
            {
                return this.pLocation;
            }
            set
            {
                this.pLocation = value;
            }
        }

        public Khung()
        { }

        public void RunKhung()
        {
            if (Pbox.Location.X <= 150)
                Pbox.Left += 5;
        }

        public void TaoKhung(Form f)
        {
            //    Form1.p.Y -= 40;
            Pbox = new PictureBox();
            Pbox.Location = GamePlay.p;
            Pbox.Size = new Size(200, 40);
            Pbox.Tag = "block";
            //this.pBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Pbox.BackColor = Color.Blue;
            f.Controls.Add(Pbox);
        }
    }
}

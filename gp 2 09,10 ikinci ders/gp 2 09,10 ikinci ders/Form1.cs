using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp_2_09_10_ikinci_ders
{
    public partial class Form1 : Form
    {
        Point merkez1, merkez2, merkez3, merkez4;
        Point kose1, kose2, kose3, kose4;

     

        Timer timer = new Timer();
        bool disaricik = true;
        int hız = 5;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            merkez1 = button1.Location;
            merkez2 = button2.Location;
            merkez3 = button3.Location;
            merkez4 = button4.Location;


            kose1 = new Point(0, 0);
            kose2 = new Point(ClientSize.Width - button2.Width, 0);
            kose3 = new Point(ClientSize.Width - button3.Width, ClientSize.Height - button3.Height);
            kose4 = new Point(0, ClientSize.Height - button4.Height);


            timer.Interval = 20;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

   
            private void MoveButton(Button btn, Point target)
        {
            
            int hedefX = target.X;
            int hedefY = target.Y;

            
            int mevcutX = btn.Left;
            int mevcutY = btn.Top;

            int hiz = 5; 

            
            if (mevcutX < hedefX)
                btn.Left += hiz; 
            else if (mevcutX > hedefX)
                btn.Left -= hiz; 

            
            if (mevcutY < hedefY)
                btn.Top += hiz; 
            else if (mevcutY > hedefY)
                btn.Top -= hiz; 
        }
        private bool AtTarget(Button btn, Point target)
        {
            return Math.Abs(btn.Left - target.X) < hız && Math.Abs(btn.Top - target.Y) < hız;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (disaricik)
            {
                
                MoveButton(button1, kose1);
                MoveButton(button2, kose2);
                MoveButton(button3, kose3);
                MoveButton(button4, kose4);

                
                if (AtTarget(button1, kose1) && AtTarget(button2, kose2) &&
                    AtTarget(button3, kose3) && AtTarget(button4, kose4))
                {
                    disaricik = false;
                }
            }
            else
            {
                
                MoveButton(button1, merkez1);
                MoveButton(button2, merkez2);
                MoveButton(button3, merkez3);
                MoveButton(button4, merkez4);

                
                if (AtTarget(button1, merkez1) && AtTarget(button2, merkez2) &&
                    AtTarget(button3, merkez3) && AtTarget(button4, merkez4))
                {
                    disaricik = true;
                }
            }
        }

    }
}

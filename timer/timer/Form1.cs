using System.Windows.Forms;
using System;

namespace timer
{
    public partial class Form1 : Form
    {
        private DateTime hedefZaman;
        private DateTime baslangicZaman;
        private bool ileriSayim = true; // İlk tıkta ileri
        private bool calisiyor = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;

            
            DateTime simdi = DateTime.Now;
            GuncelleLabel(simdi, label1, label2, label3, label4);

           
            label5.Text = "00";
            label6.Text = "00";
            label7.Text = "00";
            label8.Text = "00";
        }

        
        private void GuncelleLabel(DateTime zaman, Label lSaat, Label lDakika, Label lSaniye, Label lSalise)
        {
            label5.Text = zaman.Hour.ToString("00");
            label6.Text = zaman.Minute.ToString("00");
            label7.Text = zaman.Second.ToString("00");
            label8.Text = (zaman.Millisecond / 10).ToString("00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ileriSayim)
            {
                if (baslangicZaman <= hedefZaman)
                {
                    label1.Text = baslangicZaman.Hour.ToString("00");
                    label2.Text = baslangicZaman.Minute.ToString("00");
                    label3.Text = baslangicZaman.Second.ToString("00");
                    label4.Text = (baslangicZaman.Millisecond / 10).ToString("00");

                    baslangicZaman = baslangicZaman.AddMilliseconds(10);
                }
                else
                {
                    timer1.Stop();
                    ileriSayim = false;
                    calisiyor = false;
                    button1.Enabled = true;
                }
            }
            else
            {
                if (baslangicZaman >= hedefZaman)
                {
                    label5.Text = baslangicZaman.Hour.ToString("00");
                    label6.Text = baslangicZaman.Minute.ToString("00");
                    label7.Text = baslangicZaman.Second.ToString("00");
                    label8.Text = (baslangicZaman.Millisecond / 10).ToString("00");

                    baslangicZaman = baslangicZaman.AddMilliseconds(-10);
                }
                else
                {
                    timer1.Stop();
                    ileriSayim = true;
                    calisiyor = false;
                    button1.Enabled = true;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (calisiyor) return;

            calisiyor = true;
            button1.Enabled = false;

            DateTime simdi = DateTime.Now;

            if (ileriSayim)
            {

                label5.Text = simdi.Hour.ToString("00");
                label6.Text = simdi.Minute.ToString("00");
                label7.Text = simdi.Second.ToString("00");
                label8.Text = (simdi.Millisecond / 10).ToString("00");


                baslangicZaman = simdi.AddMinutes(-0.2);
                hedefZaman = simdi;
            }
            else
            {

                label1.Text = simdi.Hour.ToString("00");
                label2.Text = simdi.Minute.ToString("00");
                label3.Text = simdi.Second.ToString("00");
                label4.Text = (simdi.Millisecond / 10).ToString("00");


                baslangicZaman = simdi.AddMinutes(0.2);
                hedefZaman = simdi;
            }

            timer1.Start();
        }
    }
}
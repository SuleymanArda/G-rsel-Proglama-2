using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp2_16_10_örn3
{
    public partial class Form1 : Form
    {
        

        private List<Button> gameButtons = new List<Button>();

        private List<int> correctEvenOrder = new List<int>();

        
        private int nextCorrectIndex = 0;

        
        private Random random = new Random();

        
        private int timeLeft;

        public Form1()
        {
            InitializeComponent();
        
            OyunAlaniniHazirla();
        }

        private void OyunAlaniniHazirla()
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(60, 40);
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                btn.Visible = false; 
                btn.Click += GameButton_Click;

                gameButtons.Add(btn);
                pnlOyunAlani.Controls.Add(btn);
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            btnBasla.Enabled = false;
            listBoxGecmis.Items.Clear();
            correctEvenOrder.Clear();
            nextCorrectIndex = 0;

            HashSet<int> uniqueNumbers = new HashSet<int>();
            while (uniqueNumbers.Count < 10)
            {
                uniqueNumbers.Add(random.Next(0, 101));
            }

            List<int> numbers = uniqueNumbers.ToList();


            List<Rectangle> placedButtonBounds = new List<Rectangle>();

            for (int i = 0; i < 10; i++)
            {
                Button currentButton = gameButtons[i];
                currentButton.Text = numbers[i].ToString();
                    
                if (numbers[i] % 2 == 0)
                {
                    correctEvenOrder.Add(numbers[i]);
                }

                
                while (true)
                {
                
                    int maxX = pnlOyunAlani.ClientSize.Width - currentButton.Width;
                    int maxY = pnlOyunAlani.ClientSize.Height - currentButton.Height;

                    int newX = random.Next(0, maxX);
                    int newY = random.Next(0, maxY);

                
                    Rectangle newButtonRect = new Rectangle(newX, newY, currentButton.Width, currentButton.Height);

                
                    bool intersects = false;
                    foreach (Rectangle placedRect in placedButtonBounds)
                    {
                        if (newButtonRect.IntersectsWith(placedRect))
                        {
                            intersects = true; 
                            break;
                        }
                    }

                
                    if (!intersects)
                    {
                        currentButton.Location = new Point(newX, newY); 
                        placedButtonBounds.Add(newButtonRect); 
                        break; 
                    }
                }

                currentButton.Visible = true;
                currentButton.Enabled = true;
            }

            

            correctEvenOrder.Sort();

            timeLeft = 59;
            lblSure.Text = $"Süre: {timeLeft}";
            gameTimer.Start();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int number = int.Parse(clickedButton.Text);

        
            listBoxGecmis.Items.Add(number);
            
            clickedButton.Enabled = false;

            


            
            if (number % 2 != 0)
            {
                OyunBitti(false, "Yanlış! Tek sayıya bastınız. Kaybettiniz!");
                return;
            }

            
            
            if (correctEvenOrder.Count > nextCorrectIndex && number == correctEvenOrder[nextCorrectIndex])
            {
            
                nextCorrectIndex++;

                
                if (nextCorrectIndex == correctEvenOrder.Count)
                {
                    OyunBitti(true, "Tebrikler! Tüm çift sayılara doğru sırada bastınız. Kazandınız!");
                }
            }
            else 
            {
                OyunBitti(false, "Yanlış sıra! Daha küçük bir çift sayıya basmalıydınız. Kaybettiniz!");
            }
        }

        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblSure.Text = $"Süre: {timeLeft}";

            if (timeLeft <= 0)
            {
                OyunBitti(false, "Süre doldu! Kaybettiniz!");
            }
        }

        
        private void OyunBitti(bool kazandiMi, string mesaj)
        {
        
            gameTimer.Stop();

        
            foreach (Button btn in gameButtons)
            {
                btn.Enabled = false;
            }

        
            MessageBox.Show(mesaj, "Oyun Bitti");

        
            btnBasla.Enabled = true;
        }
    }
}
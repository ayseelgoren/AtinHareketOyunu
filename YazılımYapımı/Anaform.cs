using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımı
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        int click = 0 ,s;
        List<Button> buttonlar = new List<Button>();
      //  Button[,] b = new Button[Form1.boyut, Form1.boyut];
        Button[] butt = new Button[Form1.boyut*Form1.boyut];
        private void Anaform_Load(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < Form1.boyut; i++)
            {
                for (int j = 0; j < Form1.boyut; j++)
                {

                    sayac++;

                    Button b= new Button();
                    b.Location = new System.Drawing.Point(j * 60, i * 50);
                    b.Size = new System.Drawing.Size(50, 40);
                    b.BackColor = Color.DarkGray;
                    b.Name = (i+1).ToString() + (j+1).ToString();

                    buttonlar.Add(b);
                    this.pictureBox1.Controls.Add(b);                  
                    b.Click += new EventHandler(b_Click);//b.Click diyerek tıklama özelliğine bir event tanımladık.
                  
                }
            }
         

        }
        int yeni;
        private void b_Click(object sender, EventArgs e)
        {
            click++;
            Button button = (sender as Button);
            
            
            foreach (Button but in buttonlar)
            {
                if (but == button)
                {
                    if (click == 1)
                    {
                        but.BackColor = Color.White;
                        Kontrol(int.Parse(button.Name));
                        butt[click - 1] = button;
                        button.Text = click.ToString();
                        label1.Text = click + ". HAMLE ";
                    }
                    else
                    {
                        if (but.BackColor == Color.DarkBlue)
                        {
                            but.BackColor = Color.White;
                            foreach (Button btt in buttonlar)
                            {

                                if (btt.BackColor == Color.DarkBlue && btt != button)
                                    btt.BackColor = Color.DarkGray;
                            }
                            Kontrol(int.Parse(button.Name));
                            butt[click - 1] = button;
                            button.Text = click.ToString();
                            label1.Text = click + ". HAMLE ";
                        }
                        else
                        {
                            MessageBox.Show("YANLIŞ BİR HAMLE YAPTINIZ...");
                            click--;
                            break;
                        }
                           
                
                    }
                   
                }
                
          
            }
          
            foreach (Button but in buttonlar)
            {
                for (int i = 0; i < butt.Length; i++)
			   {
                   if (but == butt[i])
                       but.BackColor = Color.White;
			   }
               
            }
          
            
            
        }
       
        public void Kontrol(int deger)
        {
            s = 0;
         int kontrol = 0;
                while (s < 8)
                {
                    if (s == 0)
                    {
                        yeni = deger + 1 + 20;//aşağı
                        foreach (Button but in buttonlar)
                        {

                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }
                                
                        }
                        

                    }
                    else if (s == 1)
                    {
                        yeni = deger + 1 - 20;//yukarı
                        foreach (Button but in buttonlar)
                        {

                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }
                                
                        }
                        
                    }
                    else if (s == 2)
                    {
                        yeni = deger + 2 + 10;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }

                        }
                    }
                    else if (s == 3)
                    {
                        yeni = deger + 2 - 10;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }

                        }
                    }
                    else if (s == 4)
                    {
                        yeni = deger - 2 + 10;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }

                        }
                    }
                    else if (s == 5)
                    {
                        yeni = deger - 2 - 10;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }

                        }
                    }
                    else if (s == 6)
                    {
                        yeni = deger - 1 - 20;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }
                                
                        }
                    
                    }
                    else if (s == 7)
                    {
                        yeni = deger - 1 + 20;
                        foreach (Button but in buttonlar)
                        {
                            if (int.Parse(but.Name) == yeni)
                            {
                                but.BackColor = Color.DarkBlue;
                                kontrol++;
                            }
                                
                        }
                        
                    }
                    else
                        MessageBox.Show("OYUN TAMAMLANMADAN SONA ERMİŞTİR...");
                    s++;    
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}


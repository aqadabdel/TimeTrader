using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TimeTraderForms
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int WIDTH = 200, HEIGHT = 200, secHAND = 97, minHAND = 80, hrHAND = 60;
        
        int cx, cy;


        Bitmap bmp;
        Graphics g;
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            this.BackColor = Color.White;
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            
            //Timer 
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timeTick);
            t.Start();
        }

        private void GrpParis_Enter(object sender, EventArgs e)
        {

        }

        private void timeTick(object sender, EventArgs e)
        {

            DateTime NyTime = DateTime.Now;
                    
            Console.WriteLine("TIME " + NyTime.ToString());
           

            DrawClock(NyTime,  pictureBox1, lblNY);
            DateTime ParisTime = DateTime.Now;
            ParisTime = ParisTime.AddHours(3);
            Console.WriteLine("TIME " + ParisTime.AddHours(2.0).ToLongTimeString());
            DrawClock(ParisTime,  pbLondon, lblLondon);
          //  DrawClock(NyTime, bmp, pictureBox3);


        }
       
        private void DrawClock(DateTime dt, PictureBox pb, Label lbl)
        {



            g = Graphics.FromImage(bmp);
            //get Time
            int ss = dt.Second;
            int mm = dt.Minute;
            int hh = dt.Hour;
            Console.WriteLine("{0} {1} {2}", hh, mm, ss);
            int[] handCoord = new int[2];

            //g clear
            g.Clear(Color.White);
            //Draw circle
            g.DrawEllipse(new Pen(Color.Black, 2f), 0, 0, WIDTH, HEIGHT);
            g.FillEllipse(new SolidBrush(Color.Lavender), 0, 0, WIDTH, HEIGHT);
            g.DrawString("12", new Font("Verdana", 14), Brushes.DarkSlateBlue, new PointF(WIDTH / 2 - 10, 4));
            g.DrawString("3", new Font("Verdana", 14), Brushes.DarkSlateBlue, new PointF(WIDTH - 20, HEIGHT / 2 - 6));
            g.DrawString("6", new Font("Verdana", 14), Brushes.DarkSlateBlue, new PointF(5, HEIGHT / 2 - 6));
            g.DrawString("9", new Font("Verdana", 14), Brushes.DarkSlateBlue, new PointF(WIDTH / 2 - 5, HEIGHT - 25));
            //g.DrawRectangle(new Pen(Color.Black), cx-5, cy-5, 10, 10);
            // g.DrawEllipse(new Pen(Color.Blue, 5), cx - 3, cy - 3, 3, 3);
            g.FillEllipse(new SolidBrush(Color.Lavender), cx - 3, cy - 3, 3, 3);

            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Color.Orchid, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            

            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Color.CornflowerBlue, 4f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            pb.Image = bmp;

            lbl.Text = "Analog Clock - " + hh + ":" + mm + ":" + ss;
            
            g.Dispose();
           // bmp = null;
            //bmp.Dispose();


        }

        private int[] msCoord ( int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cx - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cx - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];
            Console.WriteLine("HVAL: " + hval);
            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));
           
            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            Console.WriteLine("HANDCOORD {0} {1}", coord[0], coord[1]);
            return coord;
        }
        public Form1()
        {
            InitializeComponent();
        }

       
    }
}

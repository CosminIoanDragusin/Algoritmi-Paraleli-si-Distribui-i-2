using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APDLab1WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            int A = 5;
            int B = 3;
            int C = 2;
            int sum = A + B + C;
            double priorityA = sum / A;
            double priorityB = sum / B;
            double priorityC = sum / C;
        }

        public Dictionary<string, int> reclameleMele = new Dictionary<string, int>()
        {
          { "A.bmp",1 },
          { "B.bmp",2 },
          { "C.bmp",3 }
        };

        public void AlgorithmOrdinePrioritate()
        {
            int vectorSize = 0;
            foreach(var ad in reclameleMele)
            {
                vectorSize += ad.Value;
            }
            string[] adsPriority = new string[vectorSize];

            double pozitie;
            foreach (var ad in reclameleMele)
            {
               pozitie= vectorSize / ad.Value;

                for(double i = 0; i < vectorSize; i*=pozitie)
                {
                    if (adsPriority[(int)i] == null)
                    {

                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            while (true) 
            {
                for(int i = 0; i < 20; i++) 
                {
                    Thread.Sleep(1000);
                    if (i % 2 != 0)
                    {
                        Bitmap bmp = new Bitmap("C:\\Users\\user\\Desktop\\APD\\APDLab1WinFormsApp2\\APDLab1WinFormsApp2\\bitmap_abc\\B.bmp");
                        e.Graphics.DrawImage(bmp, 0, 0, new Rectangle(0, 0, Size.Width, Size.Height),
                        GraphicsUnit.Pixel);
                        
                    }
                    else if (i%5 == 0 ) 
                    {
                        Bitmap bmp = new Bitmap("C:\\Users\\user\\Desktop\\APD\\APDLab1WinFormsApp2\\APDLab1WinFormsApp2\\bitmap_abc\\C.bmp");
                        e.Graphics.DrawImage(bmp, 0, 0, new Rectangle(0, 0, Size.Width, Size.Height),
                        GraphicsUnit.Pixel);
                    }
                   
                    else
                    {
                        Bitmap bmp = new Bitmap("C:\\Users\\user\\Desktop\\APD\\APDLab1WinFormsApp2\\APDLab1WinFormsApp2\\bitmap_abc\\A.bmp");
                        e.Graphics.DrawImage(bmp, 0, 0, new Rectangle(0, 0, Size.Width, Size.Height),
                        GraphicsUnit.Pixel);
                    }
                    Thread.Sleep(1000);
                }
                
            }
           
        }
    }
}

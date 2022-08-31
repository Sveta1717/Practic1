using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Practic1
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            int w = 15;
            int h = 10;            
            int count = 0;
            var rand = new Random();
            ToolTip tip = new ToolTip();
            Button[,] button = new Button[w, h];

            InitializeComponent();         
            
             for (int x = 0; x < w; ++x)
            {               
                for (int y = 0; y < h; ++y)
                {
                    count++;                     
                    button[x, y] = new Button();
                    button[x, y].Parent = this;
                    button[x, y].Size = new Size(50, 50);
                    button[x, y].Location = new Point(x * button[x, y].Width, y * button[x, y].Height);
                    button[x, y].Text = String.Format("{0}", count);
                    button[x, y].BackColor = System.Drawing.Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255), rand.Next(255));
                    button[x, y].Click += new EventHandler(Click_c);
                    tip.IsBalloon = true;
                    tip.ToolTipIcon = ToolTipIcon.Info;
                    tip.UseFading = true;
                    tip.ToolTipTitle = "Натиснить кнопку!";
                    tip.SetToolTip(this.Controls[x], "Кнопка зникне!");                   
                    //this.Controls.Add(button[i, j]);
                }
            }                 
        }
        private void Click_c(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

    }
}

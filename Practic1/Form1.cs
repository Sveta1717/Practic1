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
            int _x = 0;
            int _y = 0;
            int count = 0;
            var rand = new Random();
            ToolTip tip = new ToolTip();
            Button[,] button = new Button[w, h];

            InitializeComponent();         
            
            for (int i = 0; i < w; ++i, _x += 50)
            {               
                for (int j = 0; j < h; ++j, _y += 50)
                {
                    count++;                     
                    button[i, j] = new Button();
                    button[i, j].Parent = this;
                    button[i, j].Size = new Size(50, 50);
                    button[i, j].Location = new System.Drawing.Point(_y, _x);
                    button[i, j].Text = String.Format("{0}", count);
                    button[i, j].BackColor = System.Drawing.Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255), rand.Next(255));
                    button[i, j].Click += new EventHandler(Click_c);
                    tip.IsBalloon = true;
                    tip.ToolTipIcon = ToolTipIcon.Info;
                    tip.UseFading = true;
                    tip.ToolTipTitle = "Натиснить кнопку!";
                    tip.SetToolTip(this.Controls[i], "Кнопка зникне!");                   
                    this.Controls.Add(button[i, j]);
                }
            }          
        }
        private void Click_c(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

    }
}

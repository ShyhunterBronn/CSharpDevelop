using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_GuessNumberGame
{
    public partial class Form1 : Form
    {
        int num;
        int times=0;
        System.Threading.Thread G_th;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
            for (int i = 1; i <= 100; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Name = i.ToString();
                btn.Width = 40;
                btn.Height = 40;
                btn.Location=new Point(x, y);
                x += 42;
                if (i % 10 == 0)
                {
                    x = 10;
                    y += 42;
                }
                btn.Click += button_click;
                Controls.Add(btn);

            }
             G_th = new System.Threading.Thread(delegate()
            {
                int P = 0;
                while (true)
                {
                    P = P + 1;
                    this.Invoke((MethodInvoker)delegate
                    {
                        label2.Text = P.ToString();
                    });
                    System.Threading.Thread.Sleep(1000);
                }
            });
            G_th.IsBackground = true;
            G_th.Start();
            Random r = new Random();
            num = r.Next(1,100);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            times += 1;
            Button btn = (Button)sender;
            if (btn.Text == num.ToString())
            {
                MessageBox.Show("恭喜你猜对了！ 共猜了" + times + "次" + "，用时" + label2.Text + "秒");
                G_th.Abort();
            }
            else if (Convert.ToInt32(btn.Text) > Convert.ToInt32(num.ToString()))
            {
                btn.BackColor = Color.FromName("Red");
            }
            else if (Convert.ToInt32(btn.Text) < Convert.ToInt32(num.ToString()))
            {
                btn.BackColor = Color.FromName("Yellow");
            }      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

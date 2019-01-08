using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSeason_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(comboBox1.Text))
            {
                case 1:
                case 2:
                case 3:
                    textBox1.Text = "春";
                    break;
                case 4:
                case 5:
                case 6:
                    textBox1.Text = "夏";
                    break;
                case 7:
                case 8:
                case 9:
                    textBox1.Text = "秋";
                    break;
                case 10:
                case 11:
                case 12:
                    textBox1.Text = "冬";
                    break;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(comboBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          label4.Text+=Get(Convert.ToInt32(textBox2.Text));
        }
        int Get(int i)
        {
            if(i<=0)
            {
                return 0;
            }
            else if (i <= 2)
            {
                return 1;
            }
            else
            {
                return Get(i - 1) + Get(i - 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

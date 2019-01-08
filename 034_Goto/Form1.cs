using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _034_Goto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            Array G_a = Array.CreateInstance(typeof(string),listBox1.Items.Count);
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                G_a.SetValue(listBox1.Items[j].ToString(),j);
            }
        Goto_Label:
            if (listBox1.Items[i].ToString()==textBox1.Text)
            {
                listBox1.SelectedIndex = i;
                MessageBox.Show("找到了！");
                return;
            }
            i++;
            if(i<listBox1.Items.Count)  goto Goto_Label;
            MessageBox.Show("没有您要找的书！");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Text = textBox2.Text.ToUpper();
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = textBox2.Text.ToLower();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str=textBox5.Text.ToString();
            Encoding ed = Encoding.GetEncoding("unicode");
            Byte[] b = ed.GetBytes(str);
            textBox4.Text = b[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = char.ConvertFromUtf32(Convert.ToInt32(textBox7.Text.ToString())).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          string str=  textBox9.Text.ToString();
          Byte[] b = Encoding.Default.GetBytes(str);
          short front = (short)(b[0] - '\0');
          short back = (short)(b[1] - '\0');
          textBox8.Text = (front - 160).ToString() + (back - 160).ToString();
        }
    }
}

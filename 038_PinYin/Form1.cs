using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _038_PinYin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^[\u4e00-\u9fa5]$");
            char[] noWChar=textBox1.Text.ToString().ToArray();
            textBox2.Clear();
            byte[] array = new byte[2];
            for (int i = 0; i < noWChar.Count(); i++)
            {
                if (re.IsMatch(noWChar[i].ToString()))
                {
                    Microsoft.International.Converters.PinYinConverter.ChineseChar cc = new Microsoft.International.Converters.PinYinConverter.ChineseChar(noWChar[i]);
                    string str = cc.Pinyins[0];
                    textBox2.Text = textBox2.Text + str.Substring(0,str.Length-1);
                }
                else
                {
                    MessageBox.Show("Please input chinese!");
                }
            }

                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(textBox4.Text.ToString());
           // string str = textBox4.Text.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '，')
                {
                  str.Insert(++i, Environment.NewLine);
                }
            }
            textBox3.Text = str.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         bool ver=textBox5.Text == "Admin";
         if (ver)
         {
             MessageBox.Show("successful!");
         }
         else
         {
             MessageBox.Show("fail!");
         }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = textBox6.Text.ToString();
            string str1 = textBox6.Text.ToString();
            char[] a= str1.ToCharArray();
            Array.Reverse(a, 0, a.Length);
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                str = str.Insert(i, str.Substring(len - 1));
                str = str.Remove(len);
            }
            textBox7.Text = new StringBuilder().Append(a).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = textBox9.Text;
            char[] c = str.ToCharArray();
            StringBuilder t = new System.Text.StringBuilder();
            int len = str.Length;
                for (int i = 0; i < len; i++)
                {
                    if (c[i] != ' ')
                    {
                        t = t.Append(c[i]);
                    }
                }
            textBox8.Text = t.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               string FilePath = openFileDialog1.FileName.ToString();
               label8.Text =FilePath.Substring(0,FilePath.LastIndexOf('\\'));
               label7.Text = FilePath.Substring(FilePath.LastIndexOf('\\')+1, FilePath.LastIndexOf('.') - FilePath.LastIndexOf('\\')-1);
               label6.Text = FilePath.Substring(FilePath.LastIndexOf('.'), FilePath.Length - FilePath.LastIndexOf('.'));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           char[] c= textBox10.Text.ToCharArray();
           Regex re = new Regex("^[\u4e00-\u9fa5]$");
           IEnumerator ec=c.GetEnumerator();
           int count=0;
           while (ec.MoveNext())
           {
              if(re.IsMatch(((char)ec.Current).ToString()))
              {
                  count++;
              }
           }
           textBox11.Text = count.ToString();
        }
    }
}

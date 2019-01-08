using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"c:\log.txt", FileMode.OpenOrCreate))
            {
                object o = fs as object;
                if (o != null)
                {
                    label1.Text += ":Success";
                }
                else
                {
                    label1.Text += ":Fail";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"c:\log.txt", FileMode.OpenOrCreate))
            {
                Stream S = fs as Stream;
                if (S != null)
                {
                    label2.Text += ":Success";
                }
                else
                {
                    label2.Text += ":Fail";
                }
                
            }
        }
    }
}

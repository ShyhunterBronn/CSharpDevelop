using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str ="123";
            object str1 = str;
            int i = 123;
            object i1 = i;
            if (i1 is int)
            {
                i = (int)i1;
            }
            else
            {
                MessageBox.Show("类型不匹配！");
            }
        }
    }
}

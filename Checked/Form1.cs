using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 a = Convert.ToInt16(textBox2.Text);
            Int16 b = Convert.ToInt16(textBox3.Text);
            try
            {
               a += b;
               textBox1.Text = a.ToString();
               // checked { a += b; }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("overflow");
            }
                        
        }
    }
}

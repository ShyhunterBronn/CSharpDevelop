using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Test t = new Test();
            //t.Dispose();
            using (Test t = new Test())
            {
                        
            }
        }
        class Test:IDisposable
        {
            public void Dispose()
            {
                MessageBox.Show("资源已经回收！");
            }
        }

    }
}

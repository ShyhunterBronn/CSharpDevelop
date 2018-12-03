using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Type Oint = typeof(System.Int32);
            foreach (var m in Oint.GetMethods())
            {
                richTextBox1.AppendText("方法名： " + m.Name + Environment.NewLine);
                foreach (var para in m.GetParameters())
                {
                    richTextBox1.AppendText("参数 ： " + para.Name + Environment.NewLine);

                }
            }
        }
    }
}

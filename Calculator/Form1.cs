using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
                Button btn = (Button)sender;
                label3.Text += btn.Text;
                flag = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (flag)
            {
                if(btn.Text!="=")
                {
                    label3.Text += btn.Text;
                    flag = false;
                }
                else
                {
                    DataTable dt = new DataTable();
                    Result.Text= dt.Compute(label3.Text,"").ToString();
                   // MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControlClass();
                    //sc.Language = "JavaScript";
                    //Result.Text= sc.Eval(label3.Text).ToString();
                    label3.Text = "";
                    flag = false;
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public string TimeString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello world!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            
            TimeString = CurrentTimeNow();

           
        }


        public string CurrentTimeNow()
        {

            TimeString = DateTime.Now.ToString();
            return TimeString;
        }


    }

}

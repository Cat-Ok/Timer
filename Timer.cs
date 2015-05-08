using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            
        }

        public void TimeStart(string str)
        {
            //textBox1.Text = str;
            label1.Text = str;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }

}

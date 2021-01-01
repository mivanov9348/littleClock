using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMin.Text = DateTime.Now.ToString("HH:mm");
            seconds.Text = DateTime.Now.ToString("ss");
            date.Text = DateTime.Now.ToString("dd MM yyyy");
            dayofweek.Text = DateTime.Now.ToString("dddd");

            

        }

        private void date_Click(object sender, EventArgs e)
        {
            
        }

        private void seconds_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

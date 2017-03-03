using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickCountUp
{
    public partial class Form1 : Form
    {
        int Count;

        public Form1()
        {
            InitializeComponent();
            Count = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Count = Count + 1;
            string StringCount = Count.ToString();
            label1.Text = StringCount;
        }
    }
}

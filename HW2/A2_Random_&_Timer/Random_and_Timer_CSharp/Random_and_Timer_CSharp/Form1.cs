using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_and_Timer_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Random rand = new Random();
            Double new_euro = (rand.NextDouble()) + 1;
            new_euro = Math.Round(new_euro, 2);
            this.richTextBox1.AppendText(now + " ==> " + new_euro + Environment.NewLine);
        }

        private void ButtonStart_Click(object sender, EventArgs e) => timer1.Start();


        private void ButtonStop_Click(object sender, EventArgs e) => timer1.Stop();
    }
}

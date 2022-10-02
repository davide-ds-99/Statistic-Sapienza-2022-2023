using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharpProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students Student1 = new Students();
            Student1.Name = "Davide";
            Student1.Age = 23;
            Student1.Height = 185;

            this.richTextBox1.AppendText(Student1.Name + Environment.NewLine);
            this.richTextBox1.AppendText(Student1.Age + Environment.NewLine);
            this.richTextBox1.AppendText(Student1.Height + Environment.NewLine);

            this.richTextBox1.AppendText("=====================" + Environment.NewLine);

            SomeVal val1 = new SomeVal();
            val1.SomeValues = 10;
            SomeVal val2 = new SomeVal();
            val2.SomeValues = 0;

            this.richTextBox1.AppendText("Val1 = " + val1.SomeValues + Environment.NewLine);
            this.richTextBox1.AppendText("Val2 = " + val2.SomeValues + Environment.NewLine);

            this.richTextBox1.AppendText(" After Copy " + Environment.NewLine);

            val2 = val1;
            val1.SomeValues = 99999999;

            this.richTextBox1.AppendText("Val1 = " + val1.SomeValues + Environment.NewLine);
            this.richTextBox1.AppendText("Val2 = " + val2.SomeValues + Environment.NewLine);

            this.richTextBox1.AppendText("_____________________" + Environment.NewLine);

            SomeRef ref1 = new SomeRef();
            ref1.SomeReference = 10;
            SomeRef ref2 = new SomeRef();
            ref2.SomeReference = 0;

            this.richTextBox1.AppendText("Ref1 = " + ref1.SomeReference + Environment.NewLine);
            this.richTextBox1.AppendText("Ref2 = " + ref2.SomeReference + Environment.NewLine);

            this.richTextBox1.AppendText(" After Copy " + Environment.NewLine);

            ref2 = ref1;
            ref1.SomeReference = 999;

            this.richTextBox1.AppendText("Ref1 = " + ref1.SomeReference + Environment.NewLine);
            this.richTextBox1.AppendText("Ref2 = " + ref2.SomeReference + Environment.NewLine);
        }
        public struct SomeVal
        {
            public int SomeValues;
        }

        public class SomeRef
        {
            public int SomeReference;
        }
    }
}

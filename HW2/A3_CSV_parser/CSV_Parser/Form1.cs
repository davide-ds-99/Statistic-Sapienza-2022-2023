using System;
using System.IO;
using System.Windows.Forms;
using FileHelpers;

namespace CSV_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var fileHelperEngine = new FileHelperEngine<Student>();
                var students = fileHelperEngine.ReadFile(Path.Combine(Application.StartupPath, @"..\..\..\Statistics_students_dataset_22_23 - Foglio1.csv"));
                int i = 0;
                foreach(var student in students)
                {
                    i++;
                    if (i == 1)
                    {
                        dataGridView1.ColumnCount = 4;
                        dataGridView1.Columns[0].Name = student.Name;
                        dataGridView1.Columns[1].Name = student.Sex;
                        dataGridView1.Columns[2].Name = student.Weight;
                        dataGridView1.Columns[3].Name = student.Height;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(student.Name, student.Sex, student.Weight, student.Height);
                    }
                }
            }
        }
    } 
}

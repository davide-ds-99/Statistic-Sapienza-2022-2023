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
                        dataGridView1.ColumnCount = 2;
                        dataGridView1.Columns[0].Name = student.Name;
                        dataGridView1.Columns[1].Name = student.Weight;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(student.Name, student.Weight);
                    }
                }
            }
        }
    } 
}

using System;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentinfo : Form
    {
        public frmStudentinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(textBox1.Text, textBox2.Text, textBox3.Text);

            listBox1.Items.Add(student.StudenID);
            listBox2.Items.Add(student.LastName);
            listBox3.Items.Add(student.FirstName);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

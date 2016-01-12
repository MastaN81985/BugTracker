using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newBugForm = new Form1();
            newBugForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 viewBugForm = new Form3();
            viewBugForm.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportFixForm newBugFixForm = new ReportFixForm();
            newBugFixForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Attendance.txt");
            richTextBox1.Text = str;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

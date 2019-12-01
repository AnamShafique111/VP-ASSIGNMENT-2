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
    public partial class Form13 : Form
    {
        //string[] name = new string[100];
        //string[] cgpa = new string[100];
        string name;
        string cgpa;

        public Form13()
        {
            InitializeComponent();
        }

        private void Top3Button_Click(object sender, EventArgs e)
        {

        }
        private void ListButton_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            richTextBox1.Text = str;
        }
    }
}

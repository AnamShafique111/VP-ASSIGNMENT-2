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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            richTextBox1.Text = str;
        }
    }
}

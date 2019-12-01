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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void SearchIDButton_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }
    }
}

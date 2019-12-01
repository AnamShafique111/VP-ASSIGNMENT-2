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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void PresentButton_Click(object sender, EventArgs e)
        {
            Form10 fm = new Form10();
            fm.Show();
        }

        private void AbsentButton_Click(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            fm.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

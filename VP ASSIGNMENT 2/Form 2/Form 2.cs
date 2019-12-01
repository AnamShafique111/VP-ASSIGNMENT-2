using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8();
            fm.Show();
        }

        private void Top3button_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
        }

        private void Attendancebutton_Click(object sender, EventArgs e)
        {
            Form9 fm = new Form9();
            fm.Show();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();
            fm.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

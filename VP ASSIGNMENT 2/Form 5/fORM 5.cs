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
    public partial class Form5 : Form
    {
        string id;
        public Form5()
        {
            InitializeComponent();
        }
        private void SearchByIdtextBox_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToString(SearchByIdtextBox.Text);
        }

        private void SearchByIdrichTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
            bool condition = false;
            SearchByIdtextBox.Text = id;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(id) == true)
                {
                    SearchByIdrichTextBox.Text = (words[i] + " ");
                    condition = true;
                }
                else
                {
                    condition = false;
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            SearchByIdtextBox.Clear();
            SearchByIdrichTextBox.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

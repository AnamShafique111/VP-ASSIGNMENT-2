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
    public partial class Form7 : Form
    {
        string name;
        public Form7()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchByNametextBox_TextChanged(object sender, EventArgs e)
        {
            name = Convert.ToString(SearchByNametextBox.Text);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
            bool condition = false;
            SearchByNametextBox.Text = name;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(name) == true)
                {
                    SearchByNamerichTextBox.Text = (words[i] + " ");
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
            SearchByNametextBox.Clear();
            SearchByNamerichTextBox.Clear();
        }
    }
}

﻿using System;
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
    public partial class Form10 : Form
    {
        string id;
        string name;
        public Form10()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToString(IDtextBox.Text);
        }

        private void NAMEtextBox_TextChanged(object sender, EventArgs e)
        {
            name = Convert.ToString(NAMEtextBox.Text);
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\Attendance.txt", true))
            {
                sw.WriteLine("Present");
                sw.WriteLine(id);
                sw.WriteLine(name);
                sw.WriteLine(" ");
                sw.Close();
            }
        }
        private void ListButton_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            richTextBox1.Text = str;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NAMEtextBox.Clear();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}

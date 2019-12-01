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
    public partial class Form3 : Form
    {
        string id;
        string name;
        string sem;
        string cgpa;
        string dep;
        string uni;
        public Form3()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
                using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt",true))
                {
                    sw.WriteLine(id);
                    sw.WriteLine(name);
                    sw.WriteLine(sem);
                    sw.WriteLine(cgpa);
                    sw.WriteLine(dep);
                    sw.WriteLine(uni);
                    sw.WriteLine(" ");
                    sw.Close();
                }
            }
        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToString(IDtextBox.Text);
        }
        private void NAMEtextBox_TextChanged(object sender, EventArgs e)
        {
            name = Convert.ToString(NAMEtextBox.Text);
        }
        private void SEMtextBox_TextChanged(object sender, EventArgs e)
        {
            sem = Convert.ToString(SEMtextBox.Text);
        }
        private void CGPAtextBox_TextChanged(object sender, EventArgs e)
        {
            cgpa = Convert.ToString(CGPAtextBox.Text);
        }
        private void DEPtextBox_TextChanged(object sender, EventArgs e)
        {
            dep = Convert.ToString(DEPtextBox.Text);
        }
        private void UNItextBox_TextChanged(object sender, EventArgs e)
        {
            uni = Convert.ToString(UNItextBox.Text);
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NAMEtextBox.Clear();
            SEMtextBox.Clear();
            DEPtextBox.Clear();
            UNItextBox.Clear();
        }
    }
}

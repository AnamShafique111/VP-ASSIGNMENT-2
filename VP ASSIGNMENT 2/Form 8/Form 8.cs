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
    public partial class Form8 : Form
    {
        string id;
        string s = "";
        public Form8()
        {
            InitializeComponent();
        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToString(IdtextBox.Text);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i] == id)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        lines.RemoveAt(0);
                    }
                }
                //lines.RemoveAt(0);
                //MessageBox.Show("Record Deleted");
            }
            File.WriteAllLines(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt", lines.ToArray());


            //StreamReader sr = new StreamReader(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            //StreamWriter sw = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            //while (true)
            //{
            //    s = sr.ReadLine();
            //    if(s!=null)
            //    {
            //        s = s.Remove(s.LastIndexOf("|"), 1);
            //        sw.WriteLine(s);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //sr.Close();
            //sw.Close();
            //MessageBox.Show("Record Deleted");

            //string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
            //bool condition = false;
            //IdtextBox.Text = id;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Contains(id) == true)
            //    {
            //        lines.RemoveAt(0);
            //        IdtextBox.Text = (words[i] + " ");
            //        condition = true;
            //    }
            //    else
            //    {
            //        condition = false;
            //    }
            //}
        }
    }
}

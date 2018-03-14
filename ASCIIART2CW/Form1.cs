using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASCIIART2CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape && richTextBox1.Text != "" && !richTextBox1.Text.Contains("Console.WriteLine"))
            {
                string[] List = richTextBox1.Text.Replace("\n",";").Split(';');
                string[] All = List;
                richTextBox1.Text = "";
                for (int i = 0; i < List.Length; i++)
                {
                    richTextBox1.Text += "Console.WriteLine(\"@" + List[i] + "\");" + Environment.NewLine;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("Console.WriteLine("))
            {
                richTextBox1.ForeColor = Color.Green;


            }
            else
            {
                richTextBox1.ForeColor = Color.FromArgb(192, 0, 0);


            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Contains("[Press \"Escape\" Button To Convert]"))
            richTextBox1.Text = "";
        }
    }
}

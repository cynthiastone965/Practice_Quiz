using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        string textVariable;
        int numberVariable1;
        int numberVariable2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy hump day!";
        }

        private void question2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            textVariable = question2TextBox.Text;
            question2OutputLabel.Text = "Hello " + textVariable;
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            try
            {
                numberVariable1 = Convert.ToInt32(textBox1.Text);
                numberVariable2 = Convert.ToInt32(textBox2.Text);
                question3OutputLabel.Text = numberVariable1 + " X " + numberVariable2 + " = " + numberVariable1 * numberVariable2;
            }
            catch {
                question3OutputLabel.Text = "Invalid input, try again";
            }
        }
    }
}

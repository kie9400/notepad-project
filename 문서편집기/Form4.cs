using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문서편집기
{
    public partial class Form4 : Form
    {
        private RichTextBox a = null;
        private int pos = 0;
        private bool change = true;
        public Form4()
        {
        }

        public Form4(RichTextBox s)
        {
            a = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (change)
            {
                change = false;
                pos = a.Find(textBox1.Text, 0, RichTextBoxFinds.None);
            }
            else
                pos = a.Find(textBox1.Text, pos + 1, RichTextBoxFinds.None);

            if (pos < 0)
            {
                return;
            }
            else
            {
                a.SelectedText = a.SelectedText.Replace(textBox1.Text, textBox2.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Text = a.Text.Replace(textBox1.Text, textBox2.Text);
        }
    }
}

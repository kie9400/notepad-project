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
    public partial class Form2 : Form
    {
		private RichTextBox fid = null;
		public Form2(RichTextBox sender)
        {
			fid = sender;
            InitializeComponent();
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				button1.Enabled = true;
			}
			else
				button1.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
        {
			string txt; // 찾을 단어
			string search;
			int pos;
			int Len;

			//대소문자 
			if (checkBox1.Checked)
			{
				txt = fid.Text;
				search = textBox1.Text;
			}
			else
            {
				txt = fid.Text.ToLower();
				search = textBox1.Text.ToLower();
			}
			Len = textBox1.Text.Length; //문자길이
			
			//위 아래 검색
			if (radioButton1.Checked)
			{
				if ((fid.SelectionStart - fid.SelectionLength) < 0)
					pos = -1;
				else
					pos = txt.LastIndexOf(search, fid.SelectionStart - 1);				
			}
            else
            {
				pos = txt.IndexOf(search, fid.SelectionStart + fid.SelectionLength);
			}
		 	 

			if (pos == -1)
			{
				MessageBox.Show("찾는 문자열이 없습니다.");
				return;
			}
			else
			{
				fid.SelectionStart = pos;
				fid.SelectionLength = Len;
				fid.Focus();
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}

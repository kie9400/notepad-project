using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace 문서편집기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 find;//찾기 폼
        private Form3 word = new Form3();
        private Form4 change;
        int count = 0;
       
        #region 기타
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToString(" yyyy년 MM월 dd일 hh:mm:ss ");
        }

        public void SaveDocument(string FileName)
        {
            StreamWriter SaveText = new StreamWriter(FileName, false, System.Text.Encoding.UTF8);
            SaveText.Write(textBox1.Text);
            SaveText.Close();

            word.listView1.Items.Add(FileName);
            word.listView1.Items[count].SubItems.Add(DateTime.Now.ToString("(저장) yyyy년 MM월 dd일 hh:mm:ss "));
            count++;
        }

        public void OpenDocument(string FileName)
        {
            StreamReader sr = new StreamReader(FileName, System.Text.Encoding.UTF8);
            textBox1.Text = sr.ReadToEnd();
            textBox1.SelectionStart = 0;
            sr.Close();

            word.listView1.Items.Add(FileName);
            word.listView1.Items[count].SubItems.Add(DateTime.Now.ToString("(열기) yyyy년 MM월 dd일 hh:mm:ss "));
            count++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Test = textBox1.Text;
            string Test2 = Test.Replace(" ", "");
            label5.Text = Convert.ToString(Test2.Length + "자");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            toolStripStatusLabel1.Text = "줄 : " + (textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Test = Convert.ToString(textBox1.TextLength);
            label3.Text = (Test + "자");
        }
        
   
        #endregion

        #region 메뉴 - 편집
        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //중복실행방지
            if (!(this.find == null || !find.Visible))
            {
                find.Focus();
                return;
            }
            find = new Form2(textBox1);
            find.Show();
        }

        private void 저장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //중복실행방지
            if (!(this.word == null || !word.Visible))
            {
                word.Focus();
                return;
            }
            word.ShowDialog();
        }

        private void 바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //중복실행방지
            if (!(this.change == null || !change.Visible))
            {
                change.Focus();
                return;
            }
            change = new Form4(textBox1);
            change.Show();
        }
        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength == 0)
            {
                textBox1.SelectionLength = 1;
            }
            textBox1.SelectedText = "";
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, DateTime.Now.ToString());
        }
        private void 구글로검색하ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText == "")
            {
                MessageBox.Show("선택된 텍스트가 없습니다.", "검색기능");
            }
            else
                System.Diagnostics.Process.Start("https://www.google.co.kr/search?q=" + textBox1.SelectedText);
        }
        private void 가상키보드KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path64 = System.IO.Path.Combine(Directory.GetDirectories(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            var path32 = @"C:\windows\system32\osk.exe";
            var path = (Environment.Is64BitOperatingSystem) ? path64 : path32;
            if (File.Exists(path))
            {
                Process.Start(path);
            }
        }
        #endregion

        #region 메뉴 - 파일
        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show(this, "작업중이던 문서를 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        SaveDocument(saveFileDialog1.FileName);
                    }
                }
            }
            textBox1.Clear();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OpenDocument(openFileDialog1.FileName);
        }
        private void 다른이름으로저ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "작업중이던 문서를 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveDocument(saveFileDialog1.FileName);
                }
            }
        }

        private void 저ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "작업중이던 문서를 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveDocument(saveFileDialog1.FileName);
                }
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region 메뉴 - 서식
        private void 자동줄바ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = textBox1.WordWrap ? false : true;
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
        #endregion
        
        #region 메뉴 - 보기
     
        private void 상태표시ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (상태표시ToolStripMenuItem.Checked)
            {
                상태표시ToolStripMenuItem.Checked = statusStrip1.Visible = false;
            }
            else
            {
                상태표시ToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }    
        }
        #endregion
      
        #region 메뉴 - 정보 
        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 제작자 : 삼육대학교 18학번 송호근  \n 사용자 : " + SystemInformation.UserName + "\n" + " 사용자 컴퓨터 : " + SystemInformation.ComputerName, "정보");
        }
        #endregion

        #region 상황메뉴
        private void 실행취소UToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 잘라내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기PToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength == 0)
            {
                textBox1.SelectionLength = 1;
            }
            textBox1.SelectedText = "";
        }

        private void 모두선택AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void 구글로검색GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText == "")
            {
                MessageBox.Show("선택된 텍스트가 없습니다.","검색기능");
            }
            else
                System.Diagnostics.Process.Start("https://www.google.co.kr/search?q=" + textBox1.SelectedText);
        }


        #endregion

    }
}

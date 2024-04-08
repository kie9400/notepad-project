
namespace 문서편집기
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.실행취소UToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.구글로검색GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.구글로검색하ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가상키보드KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 395);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem1,
            this.toolStripSeparator1,
            this.잘라내ToolStripMenuItem,
            this.복사CToolStripMenuItem1,
            this.붙여넣기PToolStripMenuItem1,
            this.삭제DToolStripMenuItem,
            this.toolStripSeparator2,
            this.모두선택AToolStripMenuItem1,
            this.구글로검색GToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 170);
            // 
            // 실행취소UToolStripMenuItem1
            // 
            this.실행취소UToolStripMenuItem1.Name = "실행취소UToolStripMenuItem1";
            this.실행취소UToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.실행취소UToolStripMenuItem1.Text = "실행 취소(&U)";
            this.실행취소UToolStripMenuItem1.Click += new System.EventHandler(this.실행취소UToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // 잘라내ToolStripMenuItem
            // 
            this.잘라내ToolStripMenuItem.Name = "잘라내ToolStripMenuItem";
            this.잘라내ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.잘라내ToolStripMenuItem.Text = "잘라내기(&T)";
            this.잘라내ToolStripMenuItem.Click += new System.EventHandler(this.잘라내ToolStripMenuItem_Click);
            // 
            // 복사CToolStripMenuItem1
            // 
            this.복사CToolStripMenuItem1.Name = "복사CToolStripMenuItem1";
            this.복사CToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.복사CToolStripMenuItem1.Text = "복사(&C)";
            this.복사CToolStripMenuItem1.Click += new System.EventHandler(this.복사CToolStripMenuItem1_Click);
            // 
            // 붙여넣기PToolStripMenuItem1
            // 
            this.붙여넣기PToolStripMenuItem1.Name = "붙여넣기PToolStripMenuItem1";
            this.붙여넣기PToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.붙여넣기PToolStripMenuItem1.Text = "붙여넣기(&P)";
            this.붙여넣기PToolStripMenuItem1.Click += new System.EventHandler(this.붙여넣기PToolStripMenuItem1_Click);
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.삭제DToolStripMenuItem.Text = "삭제(&D)";
            this.삭제DToolStripMenuItem.Click += new System.EventHandler(this.삭제DToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // 모두선택AToolStripMenuItem1
            // 
            this.모두선택AToolStripMenuItem1.Name = "모두선택AToolStripMenuItem1";
            this.모두선택AToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.모두선택AToolStripMenuItem1.Text = "모두 선택(&A)";
            this.모두선택AToolStripMenuItem1.Click += new System.EventHandler(this.모두선택AToolStripMenuItem1_Click);
            // 
            // 구글로검색GToolStripMenuItem
            // 
            this.구글로검색GToolStripMenuItem.Name = "구글로검색GToolStripMenuItem";
            this.구글로검색GToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.구글로검색GToolStripMenuItem.Text = "구글로 검색(&G)";
            this.구글로검색GToolStripMenuItem.Click += new System.EventHandler(this.구글로검색GToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(442, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem,
            this.도움말HToolStripMenuItem,
            this.보기VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저ToolStripMenuItem,
            this.다른이름으로저ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새파일ToolStripMenuItem
            // 
            this.새파일ToolStripMenuItem.Name = "새파일ToolStripMenuItem";
            this.새파일ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새파일ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.새파일ToolStripMenuItem.Text = "새 파일(&N)";
            this.새파일ToolStripMenuItem.Click += new System.EventHandler(this.새파일ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저ToolStripMenuItem
            // 
            this.저ToolStripMenuItem.Name = "저ToolStripMenuItem";
            this.저ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.저ToolStripMenuItem.Text = "저장(&S)";
            this.저ToolStripMenuItem.Click += new System.EventHandler(this.저ToolStripMenuItem_Click);
            // 
            // 다른이름으로저ToolStripMenuItem
            // 
            this.다른이름으로저ToolStripMenuItem.Name = "다른이름으로저ToolStripMenuItem";
            this.다른이름으로저ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.다른이름으로저ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.다른이름으로저ToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.다른이름으로저ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripMenuItem2,
            this.구글로검색하ToolStripMenuItem,
            this.찾기ToolStripMenuItem,
            this.바꾸기ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripMenuItem4,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem,
            this.저장정보ToolStripMenuItem,
            this.가상키보드KToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.실행취소UToolStripMenuItem.Text = "실행취소(&U)";
            this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.실행취소UToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // 구글로검색하ToolStripMenuItem
            // 
            this.구글로검색하ToolStripMenuItem.Name = "구글로검색하ToolStripMenuItem";
            this.구글로검색하ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.구글로검색하ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.구글로검색하ToolStripMenuItem.Text = "구글로 검색(&S)";
            this.구글로검색하ToolStripMenuItem.Click += new System.EventHandler(this.구글로검색하ToolStripMenuItem_Click);
            // 
            // 찾기ToolStripMenuItem
            // 
            this.찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            this.찾기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.찾기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.찾기ToolStripMenuItem.Text = "찾기(&F)";
            this.찾기ToolStripMenuItem.Click += new System.EventHandler(this.찾기ToolStripMenuItem_Click);
            // 
            // 바꾸기ToolStripMenuItem
            // 
            this.바꾸기ToolStripMenuItem.Name = "바꾸기ToolStripMenuItem";
            this.바꾸기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.바꾸기ToolStripMenuItem.Text = "바꾸기(&R)";
            this.바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.바꾸기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)";
            this.잘라내기TToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TToolStripMenuItem_Click);
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.복사CToolStripMenuItem.Text = "복사(&C)";
            this.복사CToolStripMenuItem.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(&P)";
            this.붙여넣기PToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PToolStripMenuItem_Click);
            // 
            // 삭제LToolStripMenuItem
            // 
            this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            this.삭제LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.삭제LToolStripMenuItem.Text = "삭제(&L)";
            this.삭제LToolStripMenuItem.Click += new System.EventHandler(this.삭제LToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(191, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(&A)";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(&D)";
            this.시간날짜DToolStripMenuItem.Click += new System.EventHandler(this.시간날짜DToolStripMenuItem_Click);
            // 
            // 저장정보ToolStripMenuItem
            // 
            this.저장정보ToolStripMenuItem.Name = "저장정보ToolStripMenuItem";
            this.저장정보ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.저장정보ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.저장정보ToolStripMenuItem.Text = "저장 정보(&Q)";
            this.저장정보ToolStripMenuItem.Click += new System.EventHandler(this.저장정보ToolStripMenuItem_Click);
            // 
            // 가상키보드KToolStripMenuItem
            // 
            this.가상키보드KToolStripMenuItem.Name = "가상키보드KToolStripMenuItem";
            this.가상키보드KToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.가상키보드KToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.가상키보드KToolStripMenuItem.Text = "가상 키보드(&K)";
            this.가상키보드KToolStripMenuItem.Click += new System.EventHandler(this.가상키보드KToolStripMenuItem_Click);
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바ToolStripMenuItem,
            this.글꼴FToolStripMenuItem});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식OToolStripMenuItem.Text = "서식(&O)";
            // 
            // 자동줄바ToolStripMenuItem
            // 
            this.자동줄바ToolStripMenuItem.CheckOnClick = true;
            this.자동줄바ToolStripMenuItem.Name = "자동줄바ToolStripMenuItem";
            this.자동줄바ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.자동줄바ToolStripMenuItem.Text = "자동 줄바꿈";
            this.자동줄바ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바ToolStripMenuItem_Click);
            // 
            // 글꼴FToolStripMenuItem
            // 
            this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.글꼴FToolStripMenuItem.Text = "글꼴(&F)";
            this.글꼴FToolStripMenuItem.Click += new System.EventHandler(this.글꼴FToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.정보ToolStripMenuItem.Text = "정보(&H)";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상태표시ToolStripMenuItem});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기VToolStripMenuItem.Text = "보기(&V)";
            // 
            // 상태표시ToolStripMenuItem
            // 
            this.상태표시ToolStripMenuItem.Name = "상태표시ToolStripMenuItem";
            this.상태표시ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.상태표시ToolStripMenuItem.Text = "상태표시줄(&S)";
            this.상태표시ToolStripMenuItem.Click += new System.EventHandler(this.상태표시ToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트 파일(*.txt) | *.txt ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "공백 포함";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(106, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "0자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "공백 제외";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "버튼을 입력하세요 ->";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "공백이 제외 된 글자수 세기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(603, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "문서 편집기";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새파일ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 잘라내ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 구글로검색GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구글로검색하ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가상키보드KToolStripMenuItem;
    }
}


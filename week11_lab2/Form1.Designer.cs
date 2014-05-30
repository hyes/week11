namespace week11_lab2
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
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장하기SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료하기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파ToolStripMenuItem
			// 
			this.파ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.불러오기ToolStripMenuItem,
            this.저장하기SToolStripMenuItem,
            this.종료하기XToolStripMenuItem});
			this.파ToolStripMenuItem.Name = "파ToolStripMenuItem";
			this.파ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.파ToolStripMenuItem.Text = "파일(&F)";
			// 
			// 불러오기ToolStripMenuItem
			// 
			this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
			this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.불러오기ToolStripMenuItem.Text = "불러오기(&O)";
			this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click_1);
			// 
			// 저장하기SToolStripMenuItem
			// 
			this.저장하기SToolStripMenuItem.Name = "저장하기SToolStripMenuItem";
			this.저장하기SToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.저장하기SToolStripMenuItem.Text = "저장하기(&S)";
			this.저장하기SToolStripMenuItem.Click += new System.EventHandler(this.저장하기SToolStripMenuItem_Click_1);
			// 
			// 종료하기XToolStripMenuItem
			// 
			this.종료하기XToolStripMenuItem.Name = "종료하기XToolStripMenuItem";
			this.종료하기XToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.종료하기XToolStripMenuItem.Text = "종료하기(&X)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 27);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 240);
			this.textBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "week11";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 저장하기SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료하기XToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;

	}
}


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

namespace week11_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
		}

        private void 종료하기xToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


		private void 불러오기ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr =new StreamReader(new FileStream(openFileDialog.FileName, FileMode.Open));
				textBox1.Text = null;

				while (sr.EndOfStream == false)
				{
					textBox1.Text += sr.ReadLine() + "\r\n";
				}
				sr.Close();
			}



		}

		private void 저장하기SToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create));
				sw.WriteLine(textBox1.Text);
				sw.Close();
			}
		}
		
	}
}



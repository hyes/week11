using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace week11_lab3
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			ArrayList students = new ArrayList();
			students.Add(new Student("가나다", "국어", 100));
			students.Add(new Student("라마바", "영어", 100));
			students.Add(new Student("사아자", "중국어", 100));
			students.Add(new Student("차카타", "프로그래밍연습", 100));

			FileStream ws = new FileStream("a.dat", FileMode.Create);
			BinaryFormatter serializer = new BinaryFormatter();
			serializer.Serialize(ws, students);
			ws.Close();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void 불러오기OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream rs = new FileStream(openFileDialog.FileName, FileMode.Open);
				BinaryFormatter serializer = new BinaryFormatter();
				ArrayList students = (ArrayList)serializer.Deserialize(rs);
				rs.Close();
			

				foreach (Student student in students) {
					listBox1.Items.Add(student.GetName() + "\t" + student.GetSubject() + "\t" + student.GetScore());
			}
		}
		}

		private void 저장하기SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//SaveFileDialog saveFileDialog = new SaveFileDialog();
			//if (saveFileDialog.ShowDialog() == DialogResult.OK)
			//{
			//    StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create));
			//    sw.WriteLine(textBox1.Text);
			//    sw.Close();
			//}
		}

		private void 종료하기ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		
	}

	[Serializable]
	class Student
		{
		private string Name;
		private string Subject;
		private int Score;
	
		public Student(string Name, string Subject, int Score)
		{
			this.Name = Name;
			this.Subject = Subject;
			this.Score = Score;
		}

		public string GetName()
		{
			return Name;
		}

		public string GetSubject()
		{
			return Subject;
		}
		public int GetScore()
		{
			return Score;
		}
	}
}

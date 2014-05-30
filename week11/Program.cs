using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace week11
{
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

	class Program
	{
		static void Main(string[] args)
		{

			ArrayList arr = new ArrayList();
			string answer;

			do
			{
				arr.Add(Add());
				Console.Write("추가로 학생 정보를 입력하시려면 Enter키를, 그만하시려면 'n'을 누르시오");
				answer = Console.ReadLine();


			} while (answer != "n");


			BinaryWriter bw = new BinaryWriter(new FileStream("students.dat", FileMode.Create));


			foreach (Student student in arr)
			{
				bw.Write(student.GetName());
				bw.Write(student.GetSubject());
				bw.Write(student.GetScore());
			}
			bw.Close();

			BinaryReader br = new BinaryReader(new FileStream("students.dat", FileMode.Open));		
			
			ArrayList newArr = new ArrayList();
			
				while (br.PeekChar() > 0)
				{
					string name = br.ReadString();
					string subject = br.ReadString();
					int score = br.ReadInt32();

					newArr.Add(new Student(name, subject, score));
				}
		
		
			foreach(Student new_s in newArr)
			{
				Console.WriteLine("name:{0}\tsubject:{1}\tscore:{2}", new_s.GetName(), new_s.GetSubject(), new_s.GetScore());
			}
			br.Close();
			
			Console.ReadLine();
		}

		public static Student Add()
		{

			Console.Write("name: ");
			string inputname = Console.ReadLine();

			Console.Write("subject: ");
			string inputsubject = Console.ReadLine();

			Console.Write("score: ");
			int inputscore = int.Parse(Console.ReadLine());

			return new Student(inputname, inputsubject, inputscore);

		}
	}
}
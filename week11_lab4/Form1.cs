using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace week11_lab4
{
    public partial class Form1 : Form
        
    {
        private ArrayList shapes = new ArrayList();
        int ran;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
			foreach (Shape shape in shapes)
			{
                 shape.Show(e.Graphics);
			}
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(200, 300);
            int bottom = random.Next(200, 300);

            ran = random.Next(1, 6);

           
            Shape newShape = null;
            switch (ran)
            {
                case 1:
                    newShape = new Rectangle(left, top, right, bottom);
                    MessageBox.Show("Rectangle 나와요~");
                   
                    break;
                case 2:
                    newShape = new Square(left, top, right - left);
                    MessageBox.Show("Square나와요");
                    break;
                case 3:
                    newShape = new Ellipse(left, top, right, bottom);
                    MessageBox.Show("Ellipse");
                    break;
                case 4:
                    newShape = new Triangle(left, top, right, bottom);
                    MessageBox.Show("Triangle!");
                    break;
                case 5:
                    newShape = new Pie(left, top, right, bottom);
                    MessageBox.Show("Pie");
                    break;
            }
        
            shapes.Add(newShape);
			Invalidate();
        }

		private void 불러오기OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				FileStream rs = new FileStream(openFileDialog1.FileName, FileMode.Open);
				BinaryFormatter serializer = new BinaryFormatter();
				shapes = (ArrayList)serializer.Deserialize(rs);
				rs.Close();
				Invalidate();
			}
		}

		private void 저장하기SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				FileStream ws = new FileStream(saveFileDialog1.FileName, FileMode.Create);
				BinaryFormatter serializer = new BinaryFormatter();
				serializer.Serialize(ws, shapes);
				ws.Close();
			}
		}
    }
}

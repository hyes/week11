using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace week11_lab4
{
	[Serializable]
	abstract class Shape
	{
		protected Point LeftTop;
		protected Point RightBottom;

		public Shape(Point LeftTop, Point RightBottom)
		{
			this.LeftTop = LeftTop;
			this.RightBottom = RightBottom;
		}

		public Shape(int Left, int Top, int Right, int Bottom)
		{
			LeftTop = new Point(Left, Top);
			RightBottom = new Point(Right, Bottom);
		}

		abstract public void Show(Graphics g);
	}

	[Serializable]
	class Rectangle : Shape
	{
		public Rectangle(int Left, int Top, int Right, int Bottom)
			: base(Left, Top, Right, Bottom)
		{
		}

		public override void Show(Graphics g)
		{
			g.FillRectangle(Brushes.SkyBlue,
				LeftTop.X, LeftTop.Y,
				RightBottom.X - LeftTop.X,
				RightBottom.Y - LeftTop.Y);

			g.DrawRectangle(Pens.Black,
				LeftTop.X, LeftTop.Y,
				RightBottom.X - LeftTop.X,
				RightBottom.Y - LeftTop.Y);
		}
	}

	[Serializable]
	class Square : Rectangle
	{
		public Square(int Left, int Top, int Width)
			: base(Left, Top, Left + Width, Top + Width)
		{
		}

		public override void Show(Graphics g)
		{
			g.FillRectangle(Brushes.Yellow,
			   LeftTop.X, LeftTop.Y,
			   RightBottom.X - LeftTop.X,
			   RightBottom.Y - LeftTop.Y);

			g.DrawRectangle(Pens.Black,
				LeftTop.X, LeftTop.Y,
				RightBottom.X - LeftTop.X,
				RightBottom.Y - LeftTop.Y);
		}
	}

	[Serializable]
	class Triangle : Shape
	{
		private Point LeftBottom;

		public Triangle(int Left, int Top, int Right, int Bottom)
			: base(Left, Top, Right, Bottom)
		{
			this.LeftBottom = new Point(Left, Bottom);
		}


		public override void Show(Graphics graphics)
		{
			Pen blackPen = new Pen(Color.Blue, 3);

			Point point1 = LeftTop;
			Point point2 = RightBottom;
			Point point3 = LeftBottom;

			Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };

			graphics.DrawPolygon(blackPen, curvePoints);
			graphics.FillPolygon(Brushes.Blue, curvePoints);
		}
	}

	[Serializable]
	class Ellipse : Shape
	{
		public Ellipse(int Left, int Top, int Right, int Bottom)
			: base(Left, Top, Right, Bottom)
		{
		}

		public override void Show(Graphics g)
		{
			Pen blackPen = new Pen(Color.Red, 3);
			int x = LeftTop.X;
			int y = LeftTop.Y;
			int width = RightBottom.X - LeftTop.X;
			int height = RightBottom.Y - LeftTop.Y;

			g.DrawEllipse(blackPen, x, y, width, height);
			g.FillEllipse(Brushes.Red, x, y, width, height);
		}
	}

	[Serializable]
	class Pie : Shape
	{
		public Pie(int Left, int Top, int Right, int Bottom)
			: base(Left, Top, Right, Bottom)
		{
		}

		public override void Show(Graphics g)
		{
			Pen whitePen = new Pen(Color.White, 3);
			int x = LeftTop.X;
			int y = LeftTop.Y;
			int width = RightBottom.X - LeftTop.X;
			int height = RightBottom.Y - LeftTop.Y;

			Random pie_ran = new Random();
			int startAngle = pie_ran.Next(1, 360);
			int sweepAngle = pie_ran.Next(1, 360);

			g.DrawPie(whitePen, x, y, width, height, startAngle, sweepAngle);
			g.FillPie(Brushes.Black, x, y, width, height, startAngle, sweepAngle);
		}
	}



}

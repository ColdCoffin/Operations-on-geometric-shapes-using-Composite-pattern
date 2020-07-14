using Composite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Elipse : IShape
	{
		string name;
		Point center;
		int MajorAxes;
		int MinorAxes;
		float rotation;

		public Elipse(string name, Point center, int MajorAxes, int MinorAxes)
		{
			if (MajorAxes <= 0 || MinorAxes <= 0)
				throw new ArgumentOutOfRangeException();

			this.name = name;
			this.center = center;
			this.MajorAxes = MajorAxes;
			this.MinorAxes = MinorAxes;

		}
		public void Draw()
		{
			Console.WriteLine(name + " coordinates; center = " + center.ToString() + ", MajorAxes = " + MajorAxes + ", MinorAxes = " + MinorAxes + ", Rotation = " + rotation);
		}

		public IShape GetChild(int index)
		{
			return null;
		}

		public void MoveHorizontal(int offset)
		{
			center.X += offset;
		}

		public void MoveVertical(int offset)
		{
			center.Y += offset;
		}


		public void Rotate(float degree)
		{
			rotation += degree;
		}

		public void Select(IShape shape)
		{
			return;
		}

		public void Unselect(string name)
		{
			return;
		}
		public string GetName()
		{
			return name;
		}
	}
}

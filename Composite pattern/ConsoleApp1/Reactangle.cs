using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Reactangle : IShape
	{

		public readonly string name;
		Point center;
		int hight;
		int width;
		float rotation;

		public Reactangle(string name, Point center, int hight, int width)
		{
			if (hight <= 0 || width <= 0)
				throw new ArgumentOutOfRangeException();

			this.name = name;
			this.center = center;
			this.hight = hight;
			this.width = width;
		}

		public void Draw() 
		{

			Console.WriteLine(name + " coordinates; center = " + center.ToString() + ", hight = " + hight + ", wide = " + width + ", Rotation = " + rotation);

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

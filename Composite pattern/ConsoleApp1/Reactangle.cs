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

		string name = "Reactangle";
		Point center;
		int hight;
		int wide;

		public Reactangle(Point center, int hight, int wide)
		{
			this.center = center;
			this.hight = hight;
			this.wide = wide;
		}

		public void Add(IShape shape)
		{
			return;
		}

		public void Draw() 
		{

			Console.WriteLine(name + " coordinates; center = " + center.ToString() + ", hight = " + hight + ", wide = " + wide);

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

		public void Remove(int index)
		{
			return;
		}

		public void Rotate(float degree)
		{
			throw new NotImplementedException();
		}

	}
}

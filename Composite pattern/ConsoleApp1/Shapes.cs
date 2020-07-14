using Composite;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Shapes : IShape
	{

		public readonly string name;
		private List<IShape> shapes = new List<IShape>();

		public Shapes(string name)
		{
			this.name = name;
		}

		public void Draw()
		{
			Console.WriteLine(name + ";");
			foreach (var shape in shapes)
			{
				shape.Draw();
			}
		}

		public IShape GetChild(int index)
		{
			if (index > shapes.Count)
				return null;

			return shapes[index];

		}

		public void MoveHorizontal(int offset)
		{
			foreach (var shape in shapes)
			{
				shape.MoveHorizontal(offset);
			}
		}

		public void MoveVertical(int offset)
		{
			foreach (var shape in shapes)
			{
				shape.MoveVertical(offset);
			}
		}

		public void Rotate(float degree)
		{
			foreach (var shape in shapes)
			{
				shape.Rotate(degree);
			}
		}

		public void Select(IShape shape)
		{
			shapes.Add(shape);
		}

		public void Unselect(string name)
		{
			for (int i = 0; i < shapes.Count; i++)
			{
				if (name == shapes[i].GetName())
					shapes.RemoveAt(i);
			}
		}
		public string GetName()
		{
			return name;
		}
	}
}

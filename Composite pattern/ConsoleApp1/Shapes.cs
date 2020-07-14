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
		private List<IShape> shapes = new List<IShape>();


		public Shapes(List<IShape> shape)
		{
			this.shapes = shape;
		}

		public void Add(IShape shape)
		{
			shapes.Add(shape);
		}

		public void Draw()
		{
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

		public void Remove(int index)
		{
			shapes.RemoveAt(index);
		}

		public void Rotate(float degree)
		{
			throw new NotImplementedException();
		}
	}
}

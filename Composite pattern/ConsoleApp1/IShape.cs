using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public interface IShape
	{

		void Draw();
		void MoveHorizontal(int offset);
		void MoveVertical(int offset);
		void Rotate(float degree);
		void Add(IShape shape);
		void Remove(int index);
		IShape GetChild(int index);

	}
}

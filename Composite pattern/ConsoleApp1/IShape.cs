using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public interface IShape
	{
		void Select(IShape shape);
		void Unselect(string name);
		void Draw();
		void MoveHorizontal(int offset);
		void MoveVertical(int offset);
		void Rotate(float degree);
		IShape GetChild(int index);
		string GetName();
		

	}
}

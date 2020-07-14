using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Program
	{
		static void Main(string[] args)
		{
			Shapes select1 = new Shapes("Selection 1");
			Shapes select2 = new Shapes("Selection 2");

			Elipse e1 = null;
			Elipse e2 = null;

			Reactangle r1 = null;
			Reactangle r2 = null;

			try
			{
				e1 = new Elipse("e1", new System.Drawing.Point(10, 10), 10, 5);
				e2 = new Elipse("e2", new System.Drawing.Point(20, 20), 20, 10);

				r1 = new Reactangle("r1", new System.Drawing.Point(0, 0), 10, 10);
				r2 = new Reactangle("r2", new System.Drawing.Point(-10, -10), 10, 10);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("Selecting and drawing all shapes...\n");
			select1.Select(e1);
			select1.Select(e2);
			select1.Select(r1);
			select1.Select(r2);
			select1.Draw();

			Console.WriteLine("\nMoving all selected shapes 10 horizontally\n");
			select1.MoveHorizontal(10);
			select1.Draw();

			Console.WriteLine("\nMoving only r1 shapes 20 vertically\n");
			r1.MoveVertical(20);
			select1.Draw();

			Console.WriteLine("\nUnselecting e1 and r2, moving the rest of selection 30 horizontally and rotating 40 degrees\n");
			select1.Unselect("e1");
			select1.Unselect("r2");
			select1.MoveHorizontal(30);
			select1.Rotate(40);
			select1.Draw();

			Console.WriteLine("\nSelecting e1 and r2 in new selection, moving selection1 10 vertically and selection2 10 horizontally\n");
			select2.Select(e1);
			select2.Select(r2);
			select1.MoveVertical(10);
			select2.MoveHorizontal(10);
			select1.Draw();
			select2.Draw();

			Console.ReadKey();
		}
	}
}

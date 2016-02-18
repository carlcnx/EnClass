using System;
using System.Drawing;
using System.Text;
using EnClass.DiagramEditor.ClassDiagram;
using EnClass.DiagramEditor.ClassDiagram.Connections;
using EnClass.DiagramEditor.ClassDiagram.Shapes;


namespace EnClass.AssemblyCSharpImport
{
    public static class Common
    {
        /// <summary>
        /// Creates a nice arrangement for each entity.
        /// </summary>
        public static void ArrangeTypes(Diagram diagram)
        {
            const int Margin = Connection.Spacing * 2;
            const int DiagramPadding = Shape.SelectionMargin;

            int shapeCount = diagram.ShapeCount;
            int columns = (int)Math.Ceiling(Math.Sqrt(shapeCount * 2));
            int shapeIndex = 0;
            int top = Shape.SelectionMargin;
            int maxHeight = 0;

            foreach (Shape shape in diagram.Shapes)
            {
                int column = shapeIndex % columns;

                shape.Location = new Point(
                  (TypeShape.DefaultWidth + Margin) * column + DiagramPadding, top);

                maxHeight = Math.Max(maxHeight, shape.Height);
                if (column == columns - 1)
                {
                    top += maxHeight + Margin;
                    maxHeight = 0;
                }
                shapeIndex++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapDrawingDomain.Models;

namespace ShapDrawingDomain.Interface
{
    public interface IDrawing
    {
        public string ShapeDrawing(ShapeModel shapeModel, char defaultChar = '*');
        public string RightTriangleDrawing(ShapeModel shapeModel, char defaultChar = '*');
        public string TextDrawing(TextShapeModel shapeModel);
    }
}

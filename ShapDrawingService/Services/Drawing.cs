using System.Text;
using ShapDrawingDomain.Enums;
using ShapDrawingDomain.Interface;
using ShapDrawingDomain.Models;

namespace ShapDrawingDomain.Services
{
    public class Drawing : IDrawing
    {
        public Drawing()
        { }

        public string ShapeDrawing(ShapeModel shapeModel, char defaultChar = '*')
        {
            try
            {
                StringBuilder square = new StringBuilder();
                if (shapeModel != null)
                {
                    for (int i = 0; i < shapeModel.Size; i++)
                    {
                        for (int j = 0; j < shapeModel.Size; j++)
                        {
                            square.Append(defaultChar);
                        }
                        square.Append('\n');
                    }
                }
                return square.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string RightTriangleDrawing(ShapeModel shapeModel, char defaultChar = '*')
        {
            try
            {
                StringBuilder triangle = new StringBuilder();
                if (shapeModel != null)
                {
                    for (int i = 0; i < shapeModel.Size; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            triangle.Append(defaultChar);
                        }
                        triangle.Append('\n');
                    }
                }
                return triangle.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string TextDrawing(TextShapeModel shapeModel)
        {
            if (shapeModel.ShapeType == EShape.square)
            {
                return ShapeDrawing(shapeModel, shapeModel.Char);
            }
            else if (shapeModel.ShapeType == EShape.triangle)
            {
                return RightTriangleDrawing(shapeModel, shapeModel.Char);
            }
            throw new Exception("Your input shape is not valid");
        }
    }
}
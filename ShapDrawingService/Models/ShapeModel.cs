using ShapDrawingDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapDrawingDomain.Models
{
    public class ShapeModel
    {
        public string? Shape { get; set; }
        public int Size { get; set; }

        public EShape EShapeType
        {
            get
            {
                try
                {
                    return (EShape)Enum.Parse(typeof(EShape), Shape.ToLower());
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
    }

    public class TextShapeModel : ShapeModel
    {
        public char Char { get; set; }
    }
}

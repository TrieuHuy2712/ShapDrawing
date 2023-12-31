﻿using Microsoft.AspNetCore.Mvc;
using ShapDrawingDomain.Enums;
using ShapDrawingDomain.Interface;
using ShapDrawingDomain.Models;

namespace ShapDrawing.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DrawingController : Controller
    {
        private IDrawing _drawing;

        public DrawingController(IDrawing drawing)
        {
            _drawing = drawing;
        }

        [HttpPost]
        public string DrawShape([FromBody] ShapeModel shapeModel)
        {
            if (shapeModel.EShapeType == EShape.square)
            {
                return _drawing.ShapeDrawing(shapeModel);
            }
            else if (shapeModel.EShapeType == EShape.triangle)
            {
                return _drawing.RightTriangleDrawing(shapeModel);
            }
            return "Wrong input information";
        }

        [HttpPost]
        public string TextShape([FromBody] TextShapeModel shapeModel)
        {
            return _drawing.TextDrawing(shapeModel);
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShapesAPI.DTO;
using ShapesAPI.Models;

namespace ShapesAPI.Controllers
{
    [ApiController]
    [Route("shape")]
    public class ShapesController : ControllerBase
    {
        private static CircleModel _circle = new CircleModel(2.00);
        private static SquareModel _square = new SquareModel(2.00);
        private static TriangleModel _triangle = new TriangleModel(2.00, 3.00, 4.00, 5.00); //sideA, base, sideC, height
        private static LineModel _line = new LineModel(new List<int> { 2, 3 } , new List<int> { 4, 10 }); //(x1, x2), (y1,y2)

        public ShapesController()
        {
        }

        [HttpGet("/circle")]
        public CircleDTO GetCircle()
        {
            return new CircleDTO(_circle);
        }

        [HttpPut("/circle")]
        public CircleDTO UpdateCircle(double newRadius)
        {
            _circle.updateCircle(newRadius);
            return new CircleDTO(_circle);
        }

        [HttpGet("/square")]
        public SquareDTO GetSquare()
        {
            return new SquareDTO(_square);
        }

        [HttpPut("/square")]
        public SquareDTO UpdateSquare(double newSide)
        {
            _square.updateSquare(newSide);
            return new SquareDTO(_square);
        }

        [HttpGet("/triangle")]
        public TriangleDTO GetTriangle()
        {
            return new TriangleDTO(_triangle);
        }

        //[HttpPut("/triangle")]
        //public TriangleDTO UpdateTriangle(double newTBase, double newHeight, double newSideOne, double newSideTwo)
        //{
        //    _triangle.updateTriangle(newTBase, newHeight, newSideOne, newSideTwo);
        //    return new TriangleDTO(_triangle);
        //}

        [HttpPut("/triangle")]
        public TriangleDTO UpdateTriangle(double newSideA, double newBase, double newSideC, double newHeight)
        {
            if ((newSideA + newBase) <= newSideC)
            {
                return new TriangleDTO("Invalid input: make sure newSideA + newBase > Side newSideC");
            }

            _triangle.updateTriangle(newSideA, newBase, newSideC, newHeight);

            return new TriangleDTO(_triangle);

        }

        [HttpGet("/line")]
        public LineDTO Line()
        {
            return new LineDTO(_line);
        }

        [HttpPut("/line")]
        public LineDTO UpdateLine(int x1, int x2, int y1, int y2)
        {
            _line.updateLine(new List<int> { x1, x2 }, new List<int> { y1, y2 });
            return new LineDTO(_line);
        }
    }
}

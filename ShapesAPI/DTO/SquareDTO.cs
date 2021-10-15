using System;
using ShapesAPI.Models;

namespace ShapesAPI.DTO
{
    public class SquareDTO
    {
        public double area { get; set; }
        public double perimeter { get; set; }
        public double side { get; set; }

        public SquareDTO(SquareModel sideSquare)
        {
            area = sideSquare.area;
            perimeter = sideSquare.perimeter;
            side = sideSquare.side;
        }
    }
}

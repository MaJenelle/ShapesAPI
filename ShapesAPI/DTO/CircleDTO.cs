using System;
using ShapesAPI.Models;

namespace ShapesAPI.DTO
{
    public class CircleDTO
    {
        public double area { get; set; }
        public double circumference { get; set; }
        public double diameter { get; set; }
        public double radius { get; set; }

        public CircleDTO(CircleModel _radius)
        {
            area = _radius.area;
            circumference = _radius.circumference;
            diameter = _radius.diameter;
            radius = _radius.radius;
        }
    }
}

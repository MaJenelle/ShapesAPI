using System;
using ShapesAPI.DTO;

namespace ShapesAPI.Models
{
    public class CircleModel
    {
        public double area { get; set; }
        public double circumference { get; set; }
        public double diameter { get; set; }
        public double radius { get; set; }

        public CircleModel(double _radius)
        {
            this.calculateCircle(_radius);
        }

        public void updateCircle(double _radius)
        {
            this.calculateCircle(_radius);
        }

        private void calculateCircle(double _radius)
        {
            area = Math.PI * Math.Pow(_radius, 2);
            circumference = 2 * Math.PI * _radius;
            diameter = 2 * _radius;
            radius = _radius;
        }
    }
}

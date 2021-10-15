using System;
namespace ShapesAPI.Models
{
    public class SquareModel
    {
        public double area { get; set; }
        public double perimeter { get; set; }
        public double side { get; set; }


        public SquareModel(double _side)
        {
            this.calculateSquare(_side);
        }

        public void updateSquare(double _side)
        {
            this.calculateSquare(_side);
        }

        private void calculateSquare(double _side)
        {
            area = Math.Pow(_side, 2);
            perimeter = 4 * _side;
            side = _side;
        }
    }
}

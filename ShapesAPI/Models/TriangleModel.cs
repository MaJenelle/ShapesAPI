using System;
namespace ShapesAPI.Models
{
    public class TriangleModel
    {
        public double area { get; set; }
        public double perimeter { get; set; }
        public double height { get; set; }
        public double sideA { get; set; }
        public double tBase { get; set; }
        public double sideC { get; set; }
        
        public TriangleModel(double _sideA, double _tBase, double _sideC, double _height)
        {
            this.calculateTriangle(_sideA, _tBase, _sideC, _height);
        }

        public void updateTriangle(double _sideA, double _tBase, double _sideC, double _height)
        {
            this.calculateTriangle(_sideA, _tBase, _sideC, _height);
        }

        private void calculateTriangle(double _sideA, double _tBase, double _sideC, double _height)
        {
            area = (_tBase * _height) / 2;
            perimeter = _sideA + _tBase+ _sideC;
            tBase = _tBase;
            height = _height;
            sideA = _sideA;
            sideC = _sideC;
        }
    }
}

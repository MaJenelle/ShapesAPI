using System;
using ShapesAPI.Models;

namespace ShapesAPI.DTO
{
    public class TriangleDTO
    {
        public double area { get; set; }
        public double perimeter { get; set; }
        public double height { get; set; }
        public double sideA { get; set; }
        public double tBase { get; set; }
        public double sideC { get; set; }
        public string errMsg { get; set; }

        public TriangleDTO(TriangleModel _triangle)
        {
            area = _triangle.area;
            perimeter = _triangle.perimeter;
            height = _triangle.height;
            sideA = _triangle.sideA;
            tBase = _triangle.tBase;
            sideC = _triangle.sideC;
        }

        public TriangleDTO(string _errMsg)
        {
            errMsg = _errMsg;
        }
    }
}

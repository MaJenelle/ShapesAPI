using System;
using System.Collections.Generic;
using ShapesAPI.Models;

namespace ShapesAPI.DTO
{
    public class LineDTO
    {
        public List<int> startLine { get; set; }
        public List<int> endLine { get; set; }
        public int slope { get; set; }

        public LineDTO(LineModel _line)
        {
            startLine = _line.startLine;
            endLine = _line.endLine;
            slope = _line.slope;
        }
    }
}

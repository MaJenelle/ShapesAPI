using System;
using System.Collections.Generic;

namespace ShapesAPI.Models
{
    public class LineModel
    {
        public List<int> startLine { get; set; }
        public List<int> endLine { get; set; }
        public int slope { get; set; }

        public LineModel(List<int> _startLine, List<int> endLine)
        {
            this.calculateLineSlope(_startLine, endLine);
        }

        public void updateLine(List<int> _startLine, List<int> endLine)
        {
            this.calculateLineSlope(_startLine, endLine);
        }

        private void calculateLineSlope(List<int> _startLine, List<int> _endLine)
        {
            slope = (_endLine[1] - _endLine[0]) / (_startLine[1] - _startLine[0]);
            startLine = _startLine;
            endLine = _endLine;
        }
    }
}

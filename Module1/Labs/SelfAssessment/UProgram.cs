using System;
using System.Collections.Generic;

namespace SelfAssessment
{
    class UProgram
    {
        public string _programName;
        private List<Degree> _degrees = new List<Degree>();

        public UProgram(string programName)
        {
            this._programName = programName;
        }

        public void AddDegree(Degree degree)
        {
            this._degrees.Add(degree);
        }
    }
}

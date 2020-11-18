using System;

namespace NumericalIntegration_program
{
    internal class InvalidClass : Exception
    {
        public InvalidClass()
        {
        }
        public InvalidClass(string Note) : base($"Wrong equation: {Note}")
        {
        }
    }
}
using System.Collections.Generic;

namespace NumericalIntegration_program
{
    internal interface IPolynomialClass
    {
        List<int> PolynomialCoefficients { get; set; }

        void DisplayFunction();
    }
}
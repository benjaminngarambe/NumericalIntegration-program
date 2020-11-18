using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalIntegration_program
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            while (true)
            {
                double a, b;
                double[] boundaries;
                Console.WriteLine("Integral calculator \n 1.Write coefficients of polynomial function\n2. Write polynomial function\nEnter your choice:");
                var Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Please write the coefficients of polynomial function:");
                        string coefficientInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(coefficientInput)) throw new FormatException();

                        string[] spltCoefficient = coefficientInput.Split(' ');

                        List<int> coefficients = new List<int>(); //1 2 3 -4
                        for (int i = 0; i < spltCoefficient.Length; i++)
                        {
                            coefficients.Add(int.Parse(spltCoefficient[i]));
                        }
                        Console.WriteLine("\nPlease write the boudaries of integration:");
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = double.Parse(Console.ReadLine());
                        boundaries = new double[2] { a, b };
                        INtegralCalculatorClass form = new PolynomialIntegralClass(coefficients, boundaries);
                        form.DisplayFunction();
                        Console.WriteLine(form.TrapezodalMethod(1000));
                        Console.WriteLine(form.SimpsonMethod(1000));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please write the function:");
                        string infixFunction = Console.ReadLine();
                        Console.WriteLine("\nPlease write the boundaries of integration:");
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = double.Parse(Console.ReadLine());
                        boundaries = new double[2] { a, b };
                        PolynomialIntegralClass form2 = new PolynomialIntegralClass(boundaries);
                        Console.WriteLine(form2.SimpsonMethod(infixFunction, 1000));
                        Console.WriteLine(form2.TrapezodalMethod(infixFunction, 1000));

                        break;
                    default:
                        break;
                }
                Console.Write("\nDo you want to continue(y = yes/ anykey = no): ");
                if (Reask(Console.ReadLine()))
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public static bool Reask(string ans)
        {
            return (ans.ToLower() == "y");
        }
    }
}

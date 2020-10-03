using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry
                case "f":
                    result = Factorial(num1);
                    break;
                case "aot":
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "aor":
                    result = AreaOfCircle(num2);
                    break;
                case "mtbf":
                    result = MTBF(num1, num2);
                    break;
                case "br":
                    result = BasicReliability(num1, num2, num3);
                    break;
                case "ebr":
                    result = ExpectedBasicReliability(num1, num2, num3);
                    break;
                case "dd":
                    result = DensityDefect(num1, num2);
                    break;
                case "ssi":
                    result = SSI(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 < 0 || num2 < 0)
                throw new ArgumentException("Incorrect divisor");
            else if(num1.Equals(0) && num2.Equals(0))
            {
                return 1;
            }
            else
            {
                return (num1 / num2);
            }
        }

        public int Factorial(double num1)
        {
            int i = 1, facto = 1;
            if (num1 < 0)
            {
                throw new ArgumentException("Error");
            }
            else
            {
                while (i <= num1)
                {
                    facto = facto * i;
                    i++;
                }
                return (facto);
            }
        }

        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Error");
            }
            else
            {
                return num1 * num2 * 0.5;
            }
        }

        public double AreaOfCircle(double num2)
        {
            if (num2 <= 0)
            {
                throw new ArgumentException("Error");
            }
            else
            {
                double answer = 3.142 * num2 * num2;
                return Math.Round(answer, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double MTBF(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Availability(double num1, double num2)
        {
            return (num1 / num2)*100;
        }
        public double BasicReliability(double num1, double num2, double num3)
        {
            return num1 * (1 - (num2 / num3));
        }

        public double ExpectedBasicReliability(double num1, double num2, double num3)
        {
            double answer = num1 * (1 - Math.Exp(((num2 / num1) * -1) * num3));
            return Math.Round(answer, 0,MidpointRounding.ToEven);
        }
        public double DensityDefect(double num1, double num2)
        {
            double answer = num1 / num2;
            return answer;
        }
        // SSI Calculations
        public double SSI(double num1, double num2)
        {
            double answer = num1 + num2;
            return answer;
        }

        public double UnknownFunctionA(double num1, double num2)
        {
            double a = Subtract(num1, num2);
            double b = Factorial(a);
            double c = Factorial(num1);
            double d = Divide(c, b);

            return d;
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            double a = Subtract(num1, num2);
            double b = Factorial(a);
            double c = Factorial(num1);

            double d = Divide(c, c);
            double e = Factorial(d);
            double f = Multiply(e, b);

            return f;
        }
    }
}

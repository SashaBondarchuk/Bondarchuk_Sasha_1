using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class ComplexNumber
    {
        [Newtonsoft.Json.JsonProperty("Real")]
        public double Real { get; set; }
        [Newtonsoft.Json.JsonProperty("Imaginary")]
        public double Imaginary { get; set; }

        public void PrintNum()
        {
            string Message = Imaginary > 0 ? $"{Real} + {Imaginary}i" : $"{Real} - {Math.Abs(Imaginary)}i";
            Console.WriteLine(Message);
        }
        public void Sum (ComplexNumber number)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = number.Real + Real,
                Imaginary = number.Imaginary + Imaginary
            };
            result.PrintNum();
        }
        public void Subtraction(ComplexNumber number)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Real - number.Real,
                Imaginary = Imaginary - number.Imaginary
            };
            result.PrintNum();
        }
        public void Multiplication(ComplexNumber number)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = number.Real * Real - number.Imaginary * Imaginary,
                Imaginary = number.Real * Imaginary + number.Imaginary * Real
            };
            result.PrintNum();
        }
    }
}
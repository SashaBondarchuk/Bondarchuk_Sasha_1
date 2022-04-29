using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дійсну і уявну частину комплексного числа 1: ");
            ComplexNumber complexNumber1 = new ComplexNumber();

            Console.Write("Re(z) = ");
            complexNumber1.Real = double.Parse(Console.ReadLine());

            Console.Write("Im(z) = ");
            complexNumber1.Imaginary = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введіть дійсну Re(z) і уявну Im(z) частину комплексного числа 2: ");
            ComplexNumber complexNumber2 = new ComplexNumber();

            Console.Write("Re(z) = ");
            complexNumber2.Real = double.Parse(Console.ReadLine());

            Console.Write("Im(z) = ");
            complexNumber2.Imaginary = double.Parse(Console.ReadLine());

            Console.Write("\nСума чисел = ");
            complexNumber1.Sum(complexNumber2);

            Console.Write("\nРізниця чисел = ");
            complexNumber1.Subtraction(complexNumber2);

            Console.Write("\nДобуток чисел = ");
            complexNumber1.Multiplication(complexNumber2);

            SerealizeObj(complexNumber2);
            ComplexNumber complexNumber3 = DeserealizeObj();

            Console.WriteLine();
            complexNumber3.PrintNum();
        }

        static void SerealizeObj(ComplexNumber complexNumber)
        {
            var jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(complexNumber);
            var pathOut = Path.Combine(Environment.CurrentDirectory, "jsonOut.txt");
            File.WriteAllText(pathOut, jsonOut);
        }

        static ComplexNumber DeserealizeObj()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "jsonOut.txt");
            var json = File.ReadAllText(path);
            ComplexNumber complexNumber = Newtonsoft.Json.JsonConvert.DeserializeObject<ComplexNumber>(json);
            return complexNumber;
        }
    }
}

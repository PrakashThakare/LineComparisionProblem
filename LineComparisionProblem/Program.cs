using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecomp to Line Comparision Problem !");

            Console.Write("Enter Starting Point: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Ending Point: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Starting Point: ");
            Double y1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Ending Point: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("Length is : "+Length);

            Console.ReadLine();
        }
    }
}

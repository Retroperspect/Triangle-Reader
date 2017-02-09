using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineA;
            int lineB;
            int lineC;

            int memory;

            Boolean scalene = false;
            Boolean isosceles = false;
            Boolean equilateral = false;

            Console.WriteLine("Please Type the triangles first Lines Length");
            lineA = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}" + " is the length of the first line", lineA);

            Console.WriteLine("Please Type the triangles Second Lines Length");
            lineB = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}" + " is the length of the Second line", lineA);

            Console.WriteLine("Please Type the triangles Third Lines Length");
            lineC = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}" + " is the length of the Third line", lineA);

            List<int> collection = new List<int>();
            collection.Add(lineA);
            collection.Add(lineB);
            collection.Add(lineC);
            memory = 0;
            if (lineA <= 0 || lineB <= 0 || lineC <= 0)
            {
                memory -= 10;
            }
            if (lineA == lineB || lineA == lineC)
            {
                memory += 1;
            }
            if (lineB == lineA || lineB == lineC)
            {
                memory += 1;
            }
            if (lineC == lineA || lineC == lineB)
            {
                memory += 1;
            }

            if (memory == 0)
            {
                scalene = true;
                Console.WriteLine("The Triangle is a Scalene since it has no equal lines");
            }
            else if (memory == 2)
            {
                isosceles = true;
                Console.WriteLine("The Triangle is a Isosceles since it has two equal lines");
            }
            else if (memory == 3)
            {
                equilateral = true;
                Console.WriteLine("The Triangle is a Equilateral since all lines are equal");
            }
            else if (memory < 0)
            {
                Console.WriteLine("Error. input doesn't match any possible triangle");
            }
            //Console.WriteLine("{0}", memory);
            Console.ReadKey();
        }
    }
}

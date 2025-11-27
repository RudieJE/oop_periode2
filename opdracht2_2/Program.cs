using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace opdracht2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Width?");
            int width = int.Parse(Console.ReadLine());
            SurfaceArea surfaceArea = new SurfaceArea();
            surfaceArea.length = length;
            surfaceArea.width = width;
            int area = surfaceArea.Calculate();
            Console.WriteLine($"Surface Area: {area}");
        }
    }

    class SurfaceArea
    {
        public int length { get; set; }
        public int width  { get; set; }
        public int surfaceArea;
        public int Calculate()
        {
            
            return surfaceArea = length * width;
        }

        public string StringifyNull(string? param)
        {
            return param == null ? "null" : param;
        }

       
       
    }
}

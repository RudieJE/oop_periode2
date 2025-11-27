using System;
using System.Text;

namespace opdracht2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hello, World!");
            SomeClass s = new SomeClass();
            s.SayHello();
            var result = s.КтоСколько();
            foreach (var kvp in result)
            {

                Console.WriteLine($"{kvp.Key} говорил {kvp.Value} минут");
            }
        }
    }

     class SomeClass
    {
        public  void SayHello()
        {
            Console.WriteLine("Hello from blyad!");

        }
        
        public  string StringifyNull (string? param){ 
           return param ==  null ?   "null" :  param;
        }

        public  Dictionary<string, int> КтоСколько()
        {

            var g = new Dictionary<string, int> { };
                //{
                //    { "Алексей", 5 },    
                //    { "Борис", 3 },
                //    { "Виктор", 8 }
                //};
            
            Console.WriteLine("сколько минут они говорили?");
            string? nullablaAvvyet = Console.ReadLine();
            Console.WriteLine("кто говорил больше всего?");
            string nullablaAvvyet1= Console.ReadLine();
            string atvyet1 = StringifyNull(nullablaAvvyet1);
            string atvyet0 = StringifyNull(nullablaAvvyet);
            int intatvyet0 = Convert.
                ToInt32(atvyet0);
            g.Add(atvyet1, intatvyet0);
            return g;
        }
    }
}

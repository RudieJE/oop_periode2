using System;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace opdracht2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    


    }

    public class Человек
    {
        public DateTime датаРождения { get; set; }
        public string имя { get; set; }
        public int возраст { get; set; }
        public Человек(string имя, int возраст)
        {
            this.имя = имя;
            this.возраст = возраст;
        }
        public void Представиться()
        {
            Console.WriteLine($"Привет, меня зовут {имя} и мне {возраст} лет.");
        }

        public void ПраздноватьДеньРождения()
        {
            возраст++;
            Console.WriteLine($"С днем рождения, {имя}! Тебе теперь {возраст} лет.");
        }
        public void ДатаВремени()
        {
            

        }

    }
}

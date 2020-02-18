using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            A_label:
            var number = (new Random()).Next(1, 7);            
            Console.WriteLine($"My Random number is {number}");
            switch(number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Three or four");
                    break;
                case 5:
                    System.Threading.Thread.Sleep(500);                        
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                break;
            }            
        }
    }
}

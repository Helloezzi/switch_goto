using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            START:
            var number = (new Random()).Next(1, 6);
            switch(number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    END:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    goto END;
                case 5:
                    Console.WriteLine("Five");
                    goto START;
                default:
                    Console.WriteLine("Default");
                break;
            }            
        }
    }
}

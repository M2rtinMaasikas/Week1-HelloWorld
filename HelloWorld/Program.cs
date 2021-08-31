using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
          //Readline() to read the user imput from the console
          
            string username = Console.ReadLine();
            Console.WriteLine("Hello," + username); 



            Console.Read(); 


        }
    }
}

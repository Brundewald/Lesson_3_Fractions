using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class Message
    {
        public static void Start() 
        {
            Console.WriteLine("This program can read your message.\nFirst enter your message, and after enter a number.\n");
            string msg = Console.ReadLine();
            Console.Write($"\nMessage: {msg}\n");
            int nmbr = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nNumber: {nmbr}\n");

            if (msg.Is)
            {
                Console.WriteLine(msg);
            }
            else Console.WriteLine("There is no word wich contains this amount of chars.");
        }
    }
}

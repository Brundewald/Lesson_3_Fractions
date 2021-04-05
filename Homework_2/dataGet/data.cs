using System;
using System.Collections.Generic;
using System.Text;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Homework_2.dataGet
{
    class data
    {
        public static void getData(out string msg, out int nmbr)
        {
            Console.WriteLine("This program can read your message.\nFirst enter your message, and after enter a number.\n");
            msg = Console.ReadLine();
            Console.Write($"\nMessage: {msg}\n");

            nmbr = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nNumber: {nmbr}\n");
        }
    }
}

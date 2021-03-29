using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class LogPas
    {
        
        public static void Start() 
        {
            String log;
            String pas;
            Console.Write("\nEnter login: ");
            log = Console.ReadLine();
            int loglenght = log.Length;
            switch (loglenght) 
            {
                case <= 2: Console.WriteLine("Your login is too short."); break;
                case > 10: Console.WriteLine("Your login is too long."); break;
                default: Console.WriteLine(); break;
            }
                
                
                
            Console.Write("\nEnter password: ");
            pas = Console.ReadLine();
            Console.WriteLine($"\nYour login {log} and password {pas}");
        }

        
    }
}

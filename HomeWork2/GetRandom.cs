using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4
{
    class GetRandom
    {
        public static void RandomFile() 
        {
            
            Random i = new Random();
            string[] rand = new string[10];
            StreamWriter sw = new StreamWriter("random_numbers.txt");
            for (int v = 0; v <= 10 - 1; v++) 
            {                 
                sw.Write($"{rand[v] = Convert.ToString(i.Next(0, 100))};");
                sw.Flush();
            }
            sw.Close();
        }
        public static void ReadFileSR()
        {
            int c = 0;
            List<string> nl = new List<string>();
            StreamReader sr = new StreamReader("random_numbers.txt");
            while (!sr.EndOfStream)
            {                
                string[] s = sr.ReadLine().Split(';');
                for (int i = 0; i < s.Length; i++) nl.Add(s[i]);                    
            }           
            sr.Close();
            foreach (var v in nl) 
            {
                Console.Write($"{nl[c]} ");
                c++;
            } 
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace HomeWork3
{
    class GetStudents
    {
        public static void StudentsData(out List<string> listNames) 
        {            
            listNames = new List<string>();                       

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    listNames.Add(s[1] + " " + s[0]);
                    
                }
                catch { }
            }
            listNames.RemoveAt(0);
            sr.Close();         
        }
        

    }
}

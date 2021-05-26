using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace HomeWork3
{
    class GetStudentsData
    {
        public static void StudentsList(out List<string> listNames) 
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
        }//gets students first names and last names

        public static void GetCourse(out List<int> listCourse)
        {
            int bach = 0;
            int mast = 0;
            listCourse = new List<int>();

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    listCourse.Add(int.Parse(s[6]));
                    
                }
                catch { }
            }            
            sr.Close();
        }//gets students course and count bachelors and masters

        public static void GetAge(out List<string> ageAndCourse)
        {
            ageAndCourse = new List<string>();
            int yngstd = 0; //this integer is counter for students older then 18 and younger then 20
            
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    if (int.Parse(s[5]) <= 20 && int.Parse(s[5]) >= 18) 
                    {
                        string m = $"Student age: {int.Parse(s[5])} Student course: {int.Parse(s[6])}";
                        ageAndCourse.Add(m);
                        yngstd++;                                              
                    }
                }
                catch { }
            }
            sr.Close();
            ageAndCourse.Sort();

        }//gets students age and course and print it out already sorted
    }
}

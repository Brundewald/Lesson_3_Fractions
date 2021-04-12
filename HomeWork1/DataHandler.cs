using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork3
{
    class DataHandler

    {
        public static void DataViewer() 
        {
            int i=0;
            GetStudentsData.StudentsList(out List<string> listNames);
            GetStudentsData.GetCourse(out List<int> listCourse);
            GetStudentsData.GetAge(out List<string> ageAndCourse);


            foreach (var v in listNames) 
            {                
                Console.WriteLine($"Student: {v} Course: {listCourse[i]}\n");
                i++;
            }
            foreach (var v in ageAndCourse) 
            {
                Console.WriteLine(v);
            }
        }        
    }
}

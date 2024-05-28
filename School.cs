using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_v2
{
    internal class School
    {
            public string Name { get; set; }
            
            public School(string name)
            { 
                Name = name;
            }
            public string Adress { get; set; } 

            public School(string adress) 
            {
                Adress = adress;
            }
            public string TotalStudents { get; set; }
            public School(string totalstudents)
            {
                TotalStudents = totalstudents;
            }
            public string TotalTeachers { get; set; }
            public School(string totalteachers) 
            {
                TotalTeachers = totalteachers;
            }

    }

    School mySchool = new School("Jensen");
}

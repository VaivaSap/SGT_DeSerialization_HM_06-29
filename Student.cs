using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT_DeSerialization_HM_06_29
{
    public class Student
    {
       
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public List<int> Grades { get; set; }
    
    }
}
//{ "id":100,"name":"Gusts","surname":"Link","grades":[4,6,7,8,9,3,5]}
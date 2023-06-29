//Create class which represents the object in the file, load/write data from/to file

using System.Text.Json;
using System;

namespace SGT_DeSerialization_HM_06_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objectManipulation = new ObjectManipulation("./test.json");

            var student = objectManipulation.Read();
            Console.WriteLine(student.Name);


            student.Grades.Add(4);
            objectManipulation.Write(student);
        }
    }
}
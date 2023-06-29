using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Create class which represents the object in the file, load/write data from/to file
namespace SGT_DeSerialization_HM_06_29
{
    public class ObjectManipulation
    {

        private string _filePath;

        public ObjectManipulation(string filePath)
        {
            _filePath = filePath;
        }  


        public Student Read()
        {

            var json = File.ReadAllText(_filePath);

            return JsonConvert.DeserializeObject<Student>(json);

        }

        public void Write(Student student) 
        {
            var json = JsonConvert.SerializeObject(student);
            File.WriteAllText(_filePath, json);
        }
    }
}

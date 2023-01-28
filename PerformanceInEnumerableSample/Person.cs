using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceInEnumerableSample
{
    public class Person
    {

        public Person(int id, string name , int age = 0)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

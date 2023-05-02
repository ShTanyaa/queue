using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt14_queue_
{
    class People
    {
        private string name;
        private string surname;
        private string second_name;
        private int age;
        private double weight;
        public People(string surname, string name, string second_name, int age, double weight)
        {
            this.surname = surname;
            this.name = name;
            this.second_name = second_name;
            this.age = age;
            this.weight = weight;
        }
        public int GetAge { get { return age; } set { age = value; } }
        public string Info()
        {
            return $"{surname} {name} {second_name} {age} {weight}";
        }
    }
}

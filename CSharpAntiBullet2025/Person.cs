using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAntiBullet2025
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private int ID;
        private string PhoneNumber;
        private string FatherName;
        private int Age;
        public Person(string fname, int age)
        {
            fname = FirstName;
            age = Age;
        }

        public void Introduce()
        {
            Console.WriteLine($"hello!/n my name is meysam naderi and have 18 years old learning visual studio and happy!");
        }
    }
    
}

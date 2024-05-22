using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructors
{
    public enum Gender
    {
        Male,
        Female,
        NotSpecified
    }

    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person(string name) : this(name, 15, Gender.NotSpecified)
        {
        }

        public Person(string name, int age) : this(name, age, Gender.NotSpecified)
        {
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Стать: {Gender}");
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
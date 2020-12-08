using System;
using System.Collections.Generic;

namespace homework7_task1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
        public Person(string name, int age, IEnumerable<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>
            {
                new Person("David", 16, new List<string>() { "0732155750", "0941533395" }),
                new Person("Anton", 31, new List<string>() { "0732155750", "0941533395" }),
                new Person("Sasha", 89, new List<string>() { "0952145758", "0941533395" }),
                new Person("Ihor", 8, new List<string>() { "0732155750", "0941533395" }),
                new Person("Ilia", 15, new List<string>() { "0732155750", "0941533395" })
            };

            foreach (var Person in PersonList)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }

            Console.WriteLine("\n Using the AddRange Method");

            PersonList.AddRange(new List<Person>() {
                new Person("Bob", 49, new List<string>() { "0732155750", "0941533395" }),
                new Person("Jake", 18, new List<string>() { "0732155750", "0941533395" })});

            foreach (var Person in PersonList)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }

            foreach (var item in PersonList)
            {
                Console.WriteLine("\n {0} phone numbers:", item.Name);
                foreach (var number in item.PhoneNumbers)
                {
                    Console.WriteLine("\t -{0}", number);
                }
            }
        }
    }
}
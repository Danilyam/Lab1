using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private Adres adress = new Adres();

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }


        public Human()
        {

        }
        public Human(string Name, string Surname, int Age, string Country, string City, string Street, int Number)
        {
            name = Name;
            surname = Surname;
            age = Age;

            adress.Adresa(Country, City, Street, Number);
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}.");
            adress.GetInfo();

        }
    }
}


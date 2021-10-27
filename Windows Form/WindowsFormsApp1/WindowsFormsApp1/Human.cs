using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Human
    {
        private int id;
        private string name;
        private string surname;
        private int age;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Human(int Id, string Name, string Surname, int Age)
        {
            id = Id;
            surname = Surname;
            name = Name;
            age = Age;
        }

    }
}

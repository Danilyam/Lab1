using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Teacher : Human
    {
        private List<Student> Student_list;
        private int counter;

        public Teacher(string Name, string Surname, int Age, string Country, string City, string Street, int Number) : base(Name, Surname, Age, Country, City, Street, Number)
        {
            counter = 0;
            Student_list = new List<Student>();
        }

        public void Add(Student human)
        {
            Student_list.Insert(0, human);
            counter += 1;
            Console.WriteLine("Успех!");
        }

        public void Remove(Student human)
        {
            if (counter == 0)
            {
                Console.WriteLine("Список пустой!");
            }

            if (counter != 0)
            {
                Student_list.Remove(human);
                Console.WriteLine("Ученик удалён из списка!");
            }

        }

        public override void GetInfo()
        {
            base.GetInfo();
            foreach (Student j in Student_list)
            {
                j.GetInfo();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Teacherlist
    {
        private List<Teacher> Teacher_list;

        public Teacherlist()
        {
            Teacher_list = new List<Teacher>();
        }

        public void Add_Teacher(Teacher teacher)
        {
            Teacher_list.Insert(0, teacher);
            Console.WriteLine("Учитель успешно добавлен");
        }

        public void Delete_Teacher(string Surname)
        {
            foreach (Teacher j in Teacher_list)
            {
                if (Surname != j.Surname)
                {
                    Teacher_list.Remove(j);
                    Console.WriteLine("Учитель успешно удалён");
                }
            }
        }

        public void GetInfo()
        {
            foreach (Teacher j in Teacher_list)
            {
                j.GetInfo();
            }
        }

    }
}

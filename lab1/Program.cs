using System;

namespace lab1
{
    class Lab1
    {


        static void Main()
        {
            Student student = new Student("Danil", "Prosenko", 18, "Ukraine", "Skadovsk", "Gorkogo", 8);
            student.GetInfo();

            Teacher teacher = new Teacher("Vladislav", "Bochkarev", 35, "Ukraine", "Kherson", "Perekopskaya", 20);
            teacher.GetInfo();

            Teacherlist teacherlist = new Teacherlist();
            teacherlist.GetInfo();
        }
    }
}

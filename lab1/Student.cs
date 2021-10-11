using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Student : Human
    {
        private int[] Marks;
        private int avaregemark;
        private tearlist rating;

        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int Number) : base(Name, Surname, Age, Country, City, Street, Number)
        {
            Marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                Marks[i] = random.Next(1, 6);
            }

            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                suma += Marks[i];
            }

            avaregemark = suma / 5;

            switch (avaregemark)
            {
                case 1:
                    rating = tearlist.Too_Bad;
                    break;

                case 2:
                    rating = tearlist.Bad;
                    break;

                case 3:
                    rating = tearlist.Ok;
                    break;

                case 4:
                    rating = tearlist.Good;
                    break;

                case 5:
                    rating = tearlist.Exellent;
                    break;
            }

        }
        enum tearlist
        {
            Exellent = 5,
            Good = 4,
            Ok = 3,
            Bad = 2,
            Too_Bad = 1
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"averagemarks = {avaregemark} rating = {rating}");
        }


    }

}
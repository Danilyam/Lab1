using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Adres
    {
        private string country;
        private string city;
        private string street;
        private int number;

        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public int Number { get { return number; } set { number = value; } }

        public void Adresa(string Country, string City, string Street, int Number)
        {
            country = Country;
            city = City;
            street = Street;
            number = Number;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Country {country}, City {city}, Street {street}, Number {number}.");
        }

    }
}
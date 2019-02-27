using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
     class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        private int Codan;
        protected int NumberOfSeats;

        public Car(string model, string brand, int year, string color)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
        }

        public Car(string model, string brand, int year, string color, int codan, int numberOfSeats) : this(model, brand, year, color)
        {
            Codan = codan;
            NumberOfSeats = numberOfSeats;
        }

       public int GetCodan()
        {
            return Codan;
        }
        public int GetNumberOfSeats()
        {
            return NumberOfSeats;
        }
        protected void ChangeNumberOfSeats(int Number)
        {
            return;
        }

    }

}

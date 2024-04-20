using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_01_lab_02_Cars_W
{
    //declaring fields
    class Car
    {
        private int year;
        private string model;
        private bool isDrivable;
        private double price;


        //Constructor
        public Car(string model, int year, double price, bool isDrivable)
        {
            this.Year = year;
            this.Model = model;
            this.IsDrivable = isDrivable;
            this.Price = price;
        }

        //getter and setter
        public int Year { get => year; set => year = value; }
        public string Model { get => model; set => model = value; }

        public bool IsDrivable { get => isDrivable; set => isDrivable = value; }
        public double Price { get => price; set => price = value; }

        //display output as string with the below format.
        public override string ToString()
        {
            return $" Model: {model}, Year: {year}, Price: {price}, IsDrivable: {IsDrivable}";
        }
    }
}
        
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Car
    {
        private string model;
        private Engine dvigatel;
        private int weight;
        private string color;



        public string Model { get; set; }
        public Engine Dvigatel { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

    }
}

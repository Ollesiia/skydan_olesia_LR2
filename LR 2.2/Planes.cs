using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Plane
    {

        public string name { get; private set; }
        public double capacity { get; private set; }
        public double carrying { get; private set; }
        public double distance { get; private set; }
        public double fuel { get; private set; }



        public Plane(string name, double capacity, double carrying, double distance, double fuel)
        {
            this.capacity = capacity;
            this.name = name;
            this.carrying = carrying;
            this.distance = distance;
            this.fuel = fuel;
        }

        public override string ToString()
        {
            return String.Format(
                "Iм'я: {0,11} || Мiсткiсть: {1,5} || Вантажопiдйомнiсть: {2,10} || Дальнiсть польоту: {3,5} ||Пальне: {4,10}",
                this.name, this.capacity, this.carrying, this.distance, this.fuel);
        }
    }
}

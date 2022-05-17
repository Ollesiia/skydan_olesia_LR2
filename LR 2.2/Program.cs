using System;

namespace Second
{
    class Program
    {

        static void Main(string[] args)
        {
            double totalPlaneCapacity = 0, totalPlaneCarrying = 0;

            Console.WriteLine("---------------------------------");
            aircompany.planeList.Add(new Plane("Airbus A380", 525, 184567, 10000, 24210));
            aircompany.planeList.Add(new Plane("Boeing-747", 624, 243600, 7406, 30477));
            aircompany.planeList.Add(new Plane("Airbus A320", 140, 520800, 7453, 253000));
            aircompany.planeList.Add(new Plane("Boeing-737", 100, 242000, 7406, 60456));
            aircompany.planeList.Add(new Plane("Boeing-777x", 384, 245600, 13000, 40345));
            Console.WriteLine(aircompany.ToString());
            Console.WriteLine("Сортируємо: ");
            aircompany.sortByname();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Сортируємо за дальнiстю польоту: ");
            aircompany.sortByDistance();
            Console.WriteLine("---------------------------------");
            foreach (Plane p in aircompany.planeList)
            {
                totalPlaneCapacity += p.capacity;
                totalPlaneCarrying += p.carrying;
            }

            Console.WriteLine("Cпiльна мiсткiсть: " + totalPlaneCapacity);
            Console.WriteLine("Спiльна вантажопiдйомнiсть: " + totalPlaneCarrying);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Лiтаки, якi вiдповiдають заданому споживанню пального: ");
            aircompany.FindPlane(20000, 40000);
            Console.WriteLine("---------------------------------");





        }
    }
}
   
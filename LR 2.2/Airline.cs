using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Second;

class aircompany
{
    public static List<Plane> planeList = new List<Plane>();
   



    public static string ToString()
    {
        StringBuilder strBuilder = new StringBuilder();
        
        foreach (var item in planeList)
        {
            strBuilder.AppendLine(item.ToString());
            
        }


        return strBuilder.ToString();
        
    }

    public static void sortByDistance()

    {
        planeList = planeList.OrderBy(x => x.distance).ToList();
        foreach (Plane plane in planeList)
        {
            
            Console.WriteLine(plane.ToString());
            
        }
    }

    public static void FindPlane(double a, double b)
    {
        foreach (Plane item in planeList)
        {
            if (item.fuel >= a && item.fuel <= b)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static void sortByname()
    {
        planeList = planeList.OrderBy(x => x.name).ToList();
        foreach(Plane plane in planeList)
        {
            Console.WriteLine(plane.ToString());
        }
    }

    
}

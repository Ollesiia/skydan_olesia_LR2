using System;
using System.Diagnostics.Eventing.Reader;

namespace laba
{
    
    class Clothes {
        public string  color, size, type;
        public static System.Collections.ArrayList clothes = new System.Collections.ArrayList();


        public void dress()
        {
            Console.WriteLine("----------------------------------");
            Console.Write(String.Format("Введiть колiр: "));
             this.color = Console.ReadLine();
            Console.Write(String.Format("Введiть розмiр: "));
            this.size = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            
            clothes.Add(this);
        }

        public static void choose_type(){
            Console.Write("Введiть одяг, який ви хочете одягнути: ");
            string type = Console.ReadLine();
            if (type == "взуття")
            {
                Shoes shoes = new Shoes(type);
                shoes.dress();
            }
            else if (type == "куртка")
            {
                Jacket jacket = new Jacket(type);
                jacket.dress();
            }

            else if (type == "сорочка")
            {
                Shirt shirt = new Shirt(type);
                shirt.dress();
            }

            else if (type == "джинси")
            {
                Trousers trousers = new Trousers(type);
                trousers.dress();
            }
            else
            {
                Console.WriteLine("Такого нема у вашому гардеробi(");
            }
            

        }
        
        public static void print()
        {
            Console.WriteLine();
            for (int index = 0; index < clothes.Count; index++)
            {
                Console.WriteLine(clothes[index].ToString());
            }
        }


        public override string ToString()
        {
            return this.type +":" +  " Колір: " + this.color + " Розмір: " + this.size;
        }

    }

    class Shoes : Clothes
    {   
        public Shoes(string type)
        {
            this.type = type;
        }
        
    }

    class Jacket : Clothes
    {
        public Jacket(string type)
        {
            this.type = type;
        }

    }

    class Shirt : Clothes
    {
        public Shirt(string type)
        {
            this.type = type;
        }

    }

    class Trousers : Clothes
    {
        public Trousers(string type)
        {
            this.type = type;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Collections.ArrayList wardrobe = Clothes.clothes;
            Clothes.choose_type();
            Clothes.choose_type();
            Clothes.choose_type();
            Clothes.choose_type();
            Clothes.print();
        }
    }


}

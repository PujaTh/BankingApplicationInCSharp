using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Building f1 = new Flat("flat", "2BHK", "303");
            f1.showData();


            Console.ReadLine();*/
            Console.WriteLine("Enter the type of building(Flat/Villa)");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the capacity of building(2BHk/3BHK/4BHK)");
            string capacity = Console.ReadLine();
            Console.WriteLine("Enter the dimensions of building(flat no /villa dimensions(34x45,56x78,70x23))");
            string dimensions = Console.ReadLine();
            
            Building building;//= new Accenture(id, name, dept, desg, basicSalary);
            if (type.ToLower().Equals("flat"))
            {
                building = new Flat(type,capacity, dimensions);
            }
            else
            {
                building = new Villa(type, capacity, dimensions);
            }
            building.showData();

            Console.ReadLine();
        }
        
    }


    class Building
    {
        
        public string type;
        public string capcity;
        public Building(string _type, string _capacity)
        {
            this.type=_type;
            this.capcity = _capacity;
           
        }
        public virtual void showData()
        { 
        }
    }

    class Flat : Building
    {
        string dimension;
        public Flat(string _type, string _capacity,string _flatNo):base(_type,_capacity)
        {
            this.dimension = _flatNo;
        }

        public override  void showData()
        {
            Console.WriteLine("****Flat details are*****");
            Console.WriteLine("you have selected building type: "+type);
            Console.WriteLine("capacity : " + capcity);
            Console.WriteLine("Dimension : "+dimension);
        }
    }

    class Villa : Building
    {
        string dimensions;
        public Villa(string _type, string _capacity, string _dimensions)
            : base(_type, _capacity)
        {
            this.dimensions = _dimensions;
        }

        public override void showData()
        {
            Console.WriteLine("****Villa details are*****");
            Console.WriteLine("you have selected building should be " + type);
            Console.WriteLine("capacity : " + capcity);
            Console.WriteLine("Dimension : " + dimensions);
        }
    }
}

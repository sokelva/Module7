using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //class BaseClass
    //{
    //    protected string Name;

    //    public BaseClass(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public string Description;

    //    public int Counter;

    //    public DerivedClass(string name,string description) : base(name)
    //    {
    //        Description = description;
    //    }

    //    public DerivedClass(string name, string description, int counter) : this(name, description)
    //    {
    //        Counter = counter;
    //        Console.WriteLine("Первый параметр: {0}; второй параметр: {1}; третий параметр:{2}", name, description, counter);
    //        //Console.ReadKey();

    //    }
    //}

    class Car
    {
        public int Mileage;

        public Car()
        {
            Mileage = 0;
        }

        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car");
            Mileage++;
        }
    }

    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;

        public double Gas;

        public double Electricity;

        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }

        public override void Move()
        {
            Console.WriteLine("Вызван метод Move класса HybridCar");
            Mileage++;

            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }

    class BaseClass
    {

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass:BaseClass
    {

        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }

    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

}

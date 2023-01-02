using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        D d = new D();
    //        E e = new E();

    //        d.Display();
    //        ((A)e).Display();
    //        ((B)d).Display();
    //        ((A)d).Display();
    //        Console.ReadKey();
    //    }
    //}

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
    //==========================================================================
    //class Car
    //{
    //    public int Mileage;

    //    public Car()
    //    {
    //        Mileage = 0;
    //    }

    //    public virtual void Move()
    //    {
    //        Console.WriteLine("Вызван метод Move класса Car");
    //        Mileage++;
    //    }
    //}

    //enum FuelType
    //{
    //    Gas = 0,
    //    Electricity
    //}

    //class HybridCar : Car
    //{
    //    public FuelType FuelType;

    //    public double Gas;

    //    public double Electricity;

    //    public HybridCar()
    //    {
    //        Electricity = 50;
    //        Gas = 50;
    //    }

    //    public override void Move()
    //    {
    //        Console.WriteLine("Вызван метод Move класса HybridCar");
    //        Mileage++;

    //        switch (FuelType)
    //        {
    //            case FuelType.Gas:
    //                Gas -= 0.5;
    //                break;
    //            case FuelType.Electricity:
    //                Electricity -= 0.5;
    //                break;
    //        }
    //    }

    //    public void ChangeFuelType(FuelType type)
    //    {
    //        FuelType = type;
    //    }
    //}

    //class BaseClass
    //{

    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}

    //class DerivedClass:BaseClass
    //{

    //    public override void Display()
    //    {
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }
    //}

    //class Citizen
    //{
    //    public virtual double Age
    //    {
    //        get;
    //        set;
    //    }

    //    public void SayYourAge()
    //    {
    //        Console.WriteLine("Мне {0} лет", Age);
    //    }
    //}

    //class CivilServant : Citizen
    //{
    //    private double age;
    //    public override double Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            if (value < 18)
    //            {
    //                Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
    //            }
    //            else
    //            {
    //                age = value;
    //            }
    //        }
    //    }
    //}

    //class President : CivilServant
    //{
    //    private double age;
    //    public override double Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            if (value < 35)
    //            {
    //                Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
    //            }
    //            else
    //            {
    //                age = value;
    //            }
    //        }
    //    }
    //}
    //=======================================================================

    //class BaseClass
    //{
    //    public virtual int Counter
    //    {
    //        get;
    //        set;
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    private int counter;

    //    public override int Counter 
    //    {
    //        get
    //        {
    //            return counter;
    //        }
    //        set
    //        {
    //            if (value >= 0)
    //            {
    //                counter = value;
    //            }
    //        }
    //    }
    //}

    //==========================================================================
    //class BaseClass
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Метод класса BaseClass");
    //    }
    //}

    //class DerivedClass : BaseClass
    //{

    //    public override void Display()
    //    {
    //        base.Display();
    //        //DerivedClass obj = new DerivedClass();
    //        //obj.Display();
    //        Console.WriteLine("Метод класса DerivedClass");
    //    }
    //}
    //==================================================================================
    //Задание 7.2.7
    //class A
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Класс А");
    //    }
    //}

    //class B:A
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Класс B");
    //    }
    //}

    //class C:A
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Класс C");
    //    }
    //}

    //class D:B
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Класс D");
    //    }
    //}

    //class E:C
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Класс E");
    //    }
    //}
    //===================================================================
    //Задание 7.2.12

    //class Obj
    //{
    //    public int Value;

    //    public static Obj operator + (Obj a, Obj b)
    //    {
    //        return new Obj
    //        {
    //            Value = a.Value + b.Value
    //        };
    //    }

    //    public static Obj operator - (Obj a, Obj b)
    //    {
    //        return new Obj
    //        {
    //            Value = a.Value - b.Value
    //        };
    //    }

    //}
    //=====================================================================
    //ИНДЕКСАТОРЫ
    //class Book
    //{
    //    public string Name;
    //    public string Author;
    //}

    //class BookCollection
    //{
    //    private Book[] collection;

    //    public BookCollection(Book[] collection)
    //    {
    //        this.collection = collection; // this указывает на private Book[] collection;

    //    }

    //    // Индексатор по массиву
    //    public Book this[int index]
    //    {
    //        get
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                return collection[index];
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }

    //        private set
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                collection[index] = value;
    //            }
    //        }
    //    }

    //    public Book this[string name]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < collection.Length; i++)
    //            {
    //                if (collection[i].Name == name)
    //                {
    //                    return collection[i];
    //                }
    //            }

    //            return null;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        var array = new Book[] {
    //        new Book { Name = "Мастер и Маргарита", Author = "М.А. Булгаков" },
    //        new Book { Name = "Отцы и дети", Author = "И.С. Тургенев" },
    //    };
    //        BookCollection collection = new BookCollection(array);

    //        Console.ReadKey();

    //        Book book = collection[1];
    //        book = collection[-1];
    //        book = collection[4];

    //        Console.ReadKey();

    //        book = collection["Мастер и Маргарита"];

    //        Console.ReadKey();
    //    }
    //}

    //class IndexingClass
    //{
    //    private int[] array;

    //    public IndexingClass(int[] array)
    //    {
    //        this.array = array;
    //    }

    //    //ИНДЕКСАТОР ПО МАССИВУ
    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            array[index] = value;
    //        }
    //    }

    //}

    ////--------------------------------------------------
    //// Абстрактные классы
    //abstract class A
    //{

    //}

    //class B:A
    //{
    //    //A a = new A(); - ошибка - запрещена инициализация
    //}

    //---------------------------------------------------

    //abstract class FourLeggedAnimal
    //{
    //    public abstract void Describe();
    //}

    //class Dog : FourLeggedAnimal
    //{
    //    public override void Describe()
    //    {
    //        Console.WriteLine("Это животное - собака");
    //    }
    //}

    //class Cat : FourLeggedAnimal
    //{
    //    public override void Describe()
    //    {
    //        Console.WriteLine("Это животное - кошка");
    //    }
    //}

    //abstract class A
    //{
    //    public abstract void GetAnstr();
    //}

    //class B : A
    //{
    //    public override void GetAnstr()
    //    {
    //        Console.WriteLine("Класс B");
    //    }
    //}

    //class C : A
    //{
    //    public override void GetAnstr()
    //    {
    //        Console.WriteLine("Класс C");
    //    }
    //}
    //-----------------------------------------------------------------
    //Задание 7.3.3

    //abstract class ComputerPart
    //{
    //    public abstract void Work();
    //}

    //class Processor : ComputerPart
    //{
    //    public override void Work()
    //    {

    //    }
    //}

    //class MotherBoard : ComputerPart
    //{
    //    public override void Work()
    //    {

    //    }
    //}

    //class GraphicCard : ComputerPart
    //{
    //    public override void Work()
    //    {

    //    }
    //}

    //class Obj
    //{
    //    public string Name;
    //    public string Description;

    //    public static int MaxValue = 2000;

    //}
    //------------------------Задание 7.5.3 
    //class Helper
    //{
    //    public static int num1 = 3;
    //    public static int num2 = 58;

    //    public static void Swap(ref int num1, ref int num2)
    //    {

    //        int temp = num1;
    //        num1 = num2;
    //        num2 = temp;
    //        Console.WriteLine(num1);
    //        Console.WriteLine(num2);

    //        Console.ReadKey();
    //    }

    //class Car
    //{
    //    public static int MinPrice = 100_000;
    //    public static int MaxPrice;

    //    static Car()
    //    {
    //        Console.WriteLine("Вызван статический конструктор класса Car");
    //        MaxPrice = 1_000_000;
    //    }

    //    public int Price;
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Car car = new Car();

    //        //Console.WriteLine(Car.MinPrice);

    //        //Console.WriteLine(Car.MaxPrice);

    //        //Console.ReadKey();

    //        string str = "Hello";
    //        Console.WriteLine(str.GetLastChar());

    //        Console.WriteLine("Строка".GetLastChar());
    //    }
    //}

    //public static void Main(string[] args)
    //{
    //    Swap(ref num1,ref num2);
    //}

    //class Obj
    //{
    //    public string Name;
    //    public string Description;

    //    public static string Parent;
    //    public static int DaysInWeek;
    //    public static int MaxValue;

    //    static Obj()
    //    {
    //        Parent = "System.Object";
    //        DaysInWeek = 7;
    //        MaxValue = 2000;
    //    }
    //}

    //static class StringExtensions
    //{
    //    public static char GetLastChar(this string source)
    //    {
    //        return source[source.Length - 1];
    //    }
    //}

    //static class IntExtensions
    //{
    //    public static int GetNegative(this int number)
    //    {
    //        if (number > 0)
    //        {
    //            return -number;
    //        }
    //        else
    //        {
    //            return number;
    //        }
    //    }
    //    public static int GetPositive(this int number)
    //    {
    //        if (number < 0)
    //        {
    //            return -number;
    //        }
    //        else
    //        {
    //            return number;
    //        }
    //    }
    //}

    class Car<T>
    {
        public T Engine;
    }

    class ElectricEngine
    {

    }

    class GasEngine
    {

    }
    //
    class Generic<T>
    {
        public T Field = default(T); // Поле типа T
    }

}
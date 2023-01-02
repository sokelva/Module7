using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите тип доставки из представленных:");
            Delivery del = new Delivery();
            string type = Console.ReadLine();
            Console.WriteLine("Введите адрес для доставки.");
            string address = Console.ReadLine();
            del.DeliveryType(type, address);
        }
    }

    //base
    abstract class DeliveryVariant
    {
        public string[] DeliveryVar;

        public DeliveryVariant()
        {
            DeliveryVar  = new string [3] { "HomeDelivery", "PickPointDelivery", "ShopDelivery"};
        }
    }

    class Delivery : DeliveryVariant
{
        public string Address;
        public string Type;
        public DateTime DateOfDelivery;

        public Delivery(): base()
        {
            //Console.WriteLine("Доставка осуществляется 3 способами:");
            int i = 1;
            foreach (var item in DeliveryVar)
            {
                Console.WriteLine("{0}: {1}", i,item);
                i++;
            }
        }

        //public Delivery(string Type, string Address) : this()
        //{
        //    //Условия для get;set для ShopDelivery
        //    this.Type = Type;
        //    this.Address = Address;
        //}

        public void DeliveryType(string Type, string Address)
        {
            
        }
    }

    //Использование наследования;
    class HomeDelivery : Delivery
    {
        public HomeDelivery()
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", base.Type, base.Address);
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery()
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", base.Type, base.Address);
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery()
        {
            Console.WriteLine("Адрес самовывоза: ", base.Address);
        }
    }

    class Order<TDelivery,TStruct> where TDelivery : Delivery 
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }


    /// <summary>
    /// Продукт
    /// </summary>
    abstract class Product
    {

    }

    /// <summary>
    /// Категория продукта
    /// </summary>
    class CategotyProduct : Product
    {

    }

    /// <summary>
    /// Кассовый чек
    /// </summary>
    class CashReceipt
    {

    }

    /// <summary>
    /// Менеджер
    /// </summary>
    class Employee
    {
        public string Manager;
    }
}
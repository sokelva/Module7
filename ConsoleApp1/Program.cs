using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product p = new Product();
            //p.ProductBuy("");
            //-------------------------------------
            //Доставка заказа
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

        public abstract void Display(string type);

        public DeliveryVariant()
        {
            DeliveryVar  = new string [3] { "HomeDelivery", "PickPointDelivery", "ShopDelivery"};
        }
    }

    class Delivery : DeliveryVariant //base
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

        public override void Display(string type) //переопределение абстрактного класса
        {
            Console.WriteLine("Так как был выбран тип доставки {0}", type);
        }

        public virtual void DeliveryType(string Type, string Address)
        {
            this.Type = Type;
            this.Address = Address;
            Display(this.Type);
            switch (this.Type)
            {
                case "HomeDelivery":
                    HomeDelivery hd = new HomeDelivery();
                    hd.DeliveryType(this.Type, this.Address);
                    break;
                case "PickPointDelivery":
                    PickPointDelivery ppd = new PickPointDelivery();
                    ppd.DeliveryType(this.Type, this.Address);
                    break;
                case "ShopDelivery":
                    ShopDelivery sd = new ShopDelivery();
                    sd.DeliveryType(this.Type, this.Address);
                    break;
            }
        }
    }

    //Использование наследования;
    class HomeDelivery : Delivery
    {
        public HomeDelivery()
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", base.Type, base.Address);
        }

        public override void DeliveryType(string type, string address)
        {
            Console.WriteLine("Заказ будет доставлен с 10:00 до 22:00.\nБлагодарим за ваш заказ!");
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery()
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", base.Type, base.Address);
        }

        public override void DeliveryType(string type, string address)
        {
            Console.WriteLine("Забрать заказ вы можете с 10:00 до 22:00.\nБлагодарим за ваш заказ!");
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery()
        {
            Console.WriteLine("Адрес самовывоза: ", base.Address);
        }

        public override void DeliveryType(string type, string address)
        {
            Console.WriteLine("Выдача заказов осуществлется с 10:00 до 22:00.\nБлагодарим за ваш заказ и ждем вас снова!");
        }
    }

    class Order<TDelivery,TStruct> where TDelivery : Delivery 
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public Order()
        {
            Console.WriteLine("Инормация о заказе:");
        }

        public Order(string manager, string number) : this()
        {
            Console.WriteLine("Вас обслуживал {0}:", manager);
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }


    ///// <summary>
    ///// Продукт
    ///// </summary>
    //abstract class Product
    //{

    ////}

    ///// <summary>
    ///// Категория продукта
    ///// </summary>
    //class CategotyProduct : Product
    //{

    //}

    /// <summary>
    /// Кассовый чек
    /// </summary>
    class CashReceipt
    {

    }

    ///// <summary>
    ///// Менеджер
    ///// </summary>
    //class Employee
    //{
    //    public string Manager;
    //}
}
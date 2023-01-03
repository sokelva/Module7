using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct;
using MyManager;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Информация о заказе
            Console.WriteLine("Введите нормер чека заказа.");

            CashReceipt crec = new CashReceipt();
            crec.Number = Convert.ToInt32(Console.ReadLine());
            Order<Delivery> ord = new Order<Delivery>(crec.Number);
            ord.DisplayOrderItems();
            //-------------------------------------
            //Доставка заказа
            Delivery del = new Delivery();
            del.DeliveryShow();
                
            Console.WriteLine("Введите тип доставки из представленных:");
            del.DeliveryType(Console.ReadLine().ThisReplace());
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

    class Delivery : DeliveryVariant
    {
        public string Address;
        public string Type;
        //public DateTime DateOfDelivery;

        public Delivery(): base()
        {
        }

     
        public void DeliveryShow()
        {
            Console.WriteLine("Доставка осуществляется 3 способами:");
            int i = 1;
            foreach (var item in DeliveryVar)
            {
                Console.WriteLine("{0}: {1}", i, item);
                i++;
            }
        }

        public override void Display(string type) //переопределение абстрактного класса
        {
            if(type == DeliveryVar[2])
            {
                Console.WriteLine("Так как был выбран тип доставки {0}", type);
            }
        }

        public virtual void DeliveryInfo(string Type, string Address) { }

        public void DeliveryType(string Type)
        {
            this.Type = Type;
            Display(this.Type);
            switch (this.Type)
            {
                case "HomeDelivery":
                    HomeDelivery hd = new HomeDelivery();
                    this.Address = GetDeliveryAddress();
                    hd.DeliveryInfo(this.Type, this.Address);
                    break;
                case "PickPointDelivery":
                    PickPointDelivery ppd = new PickPointDelivery();
                    this.Address = GetDeliveryAddress();
                    ppd.DeliveryInfo(this.Type, this.Address);
                    break;
                case "ShopDelivery":
                    ShopDelivery sd = new ShopDelivery();
                    sd.DeliveryInfo();
                    break;
            }
            Console.ReadKey();
        }

        private static string GetDeliveryAddress()
        {
            Console.WriteLine("Введите адрес для доставки.");
            return Console.ReadLine();
        }
        
    }



    //Использование наследования;
    class HomeDelivery: Delivery
    {
        public HomeDelivery()
        {

        }

        public override void DeliveryInfo(string type, string address)
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", type, address);
            Console.WriteLine("Заказ будет доставлен с 10:00 до 22:00.\nБлагодарим за ваш заказ!");
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery()
        {
        }

        public override void DeliveryInfo(string type, string address)
        {
            Console.WriteLine("Доставка осуществляется типом {0} на адрес: {1}", type, address);
            Console.WriteLine("Забрать заказ вы можете с 10:00 до 22:00.\nБлагодарим за ваш заказ!");
        }
    }

    class ShopDelivery : Delivery
    { 
        public ShopDelivery()
        {
            
        }

        public override void DeliveryInfo(string type = null, string address = "г.Москва, Мясищева 20")
        {
            Console.WriteLine("Адрес самовывоза: {0}", address);
            Console.WriteLine("Выдача заказов осуществлется с 10:00 до 22:00.\nБлагодарим за ваш заказ и ждем вас снова!");
        }
    }

    /// <summary>
    /// ЗАКАЗ ПОКУПАТЕЛЯ
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery DeliveryType;
        private Manager<string> m;

        public Order(int number)
        {
            //string manager = m.ManagerName(number);// 
            m = new Manager<string>(); // Композиция
            m.OrderManager = m.ManagerName(number); //Один из способов применения методов обобщения
            Console.WriteLine("Инормация о заказе:");
            Console.WriteLine("Вас обслуживал: {0}.\nВаш номер заказа: {1}.", m.OrderManager, number);
        }

        public void DisplayOrderItems()
        {
            Product p = new Product();
            Console.WriteLine("Перечень продуктов в чеке:");
            p.ProductBuy();
        }
    }

    struct Description
    {

    }


    /// <summary>
    /// Кассовый чек
    /// </summary>
    class CashReceipt
    {
        private int number; 

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Номер чека должен быть больше и не равен 0!");
                }
                else
                {
                    number = value;
                }
            }
        }
     
    }

    static class CleanChars //Методы расширения
    {
        public static string ThisReplace(this string src)
        {
            return src.Replace("  ", " ").Trim();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProduct
{
    /// <summary>
    /// Продукт
    /// </summary>
    class Product : CategotyProduct
    {
        private static string[] ProductList;
        public Product() : base()
        {
            ProductList = new string[5] {"Молоко","Хлеб","Овощи","Фрукты","Конфеты"};
        }

        public void ProductBuy()
        {
            foreach (var item in ProductList)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }

    /// <summary>
    /// Категория товаров
    /// </summary>
    abstract class CategotyProduct
    {
        public CategotyProduct()
        {
            Console.WriteLine("ВАЖНО!Каждый продукт относится к определнной категории");
        }
    }
}

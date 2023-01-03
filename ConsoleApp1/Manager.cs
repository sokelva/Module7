using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManager
{
    /// <summary>
    /// Менеджер
    /// </summary>
    class Manager<T4>
    {
        public string Name;
        private int Number;
        public T4 OrderManager;

        public Manager()
        {
        }

        public string ManagerName<T2>(T2 param)
        {
            if (param.GetType() == typeof(int))
            {
                Number = Convert.ToInt32(param);

                if (Number > 0 && Number <= 400)
                {
                    Name = "Михаил";
                }
                else if (Number > 400 && Number <= 700)
                {
                    Name = "Виталий";
                } 
                else
                {
                    Name = "Алексей";
                }
            }
            return Name;

            // здесь может быть обраотка логики для номеров заказов если они типа String
        }
    }
}

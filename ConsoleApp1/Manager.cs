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

    // График работы менеджера
    class ManagerTimeTable : Manager<string>
    {
        public string TimeTableInfo;

      

    }

    //Варианты смен манагеров
    class ManagerTimeTableCollection
    {
        private ManagerTimeTable[] collection;
        
        public ManagerTimeTableCollection(ManagerTimeTable[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public ManagerTimeTable this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }

    class TimeTable
    {
        public static void GetMangerTimeTable()
        {
            //------------------------------------------------------------------
            var array = new ManagerTimeTable[]
            {
                new ManagerTimeTable
                {
                  TimeTableInfo = "Алексей. График работы: ПН, ВТ,ЧТ с 10:00 до 22:00"
                },
                new ManagerTimeTable
                {
                  TimeTableInfo = "Михаил. График работы: ВТ,СР, ВС с 10:00 до 22:00"
                },
                new ManagerTimeTable
                {
                  TimeTableInfo = "Виталий. График работы: ПТ, СБ, ВС с 10:00 до 22:00"
                }
            };
            ManagerTimeTableCollection collection = new ManagerTimeTableCollection(array);

            ManagerTimeTable timetable = collection[1];
        }
    }
}

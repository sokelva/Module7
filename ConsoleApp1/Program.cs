using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;
        
        public DerivedClass(string description) : base("Шкаф")
        {

        }

        public DerivedClass(string description, string counter) : base("Шкаф")
        {
            string name = base.Name;
            Console.WriteLine("Первый параметр: {0}; второй параметр: {1}; третий параметр:{2}", Name, description, counter);
            
        }
    }

}

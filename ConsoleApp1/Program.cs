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
        
        public DerivedClass(string name,string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
            Console.WriteLine("Первый параметр: {0}; второй параметр: {1}; третий параметр:{2}", name, description, counter);
            //Console.ReadKey();
            
        }
    }

}

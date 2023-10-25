using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ForestExample
{
    internal class Kerpe : Animal
    {
        public Kerpe(string name, bool gender) : base(name, gender)
        {
            int id = new Random().Next(999, 9999);
        }

        public bool IsHaveMushroom {  get; set; }
        public override string Name
        {
            get => base.Name;
            set
            {
                if (Gender)
                    base.Name = "Ms. " + value + "Kerpe";
                else
                    base.Name = "Mr. " + value + "Kerpe";
            }
        }
        
        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nIs have a mushroom? {(IsHaveMushroom ? "Yes" : "No")}";
        }
    }
}

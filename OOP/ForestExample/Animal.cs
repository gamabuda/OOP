using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ForestExample
{
    internal class Animal
    {
        
        public virtual int Id { get => _id;  }
        public virtual string Name
        {
            get => _name;
            set
            {
                if(Gender)
                    _name = "Ms. " + value;
                else
                    _name = "Mr. " + value;
            }
        }
        public bool Gender { get; set; }
        public Animal(string name, bool gender)
        {
            _id = new Random().Next(1, 999);
            Gender = gender;
            Name = name;
        }

        private readonly int _id;
        private string _name;

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\n";
        }
    }
}

using OOP.ForestExample;

// вывод ёжиков
//Forest forest = new Forest();
//foreach(var i in forest.Kerpes)
//{
//    Console.WriteLine(i);
//}


//Human Human = new Student();
//Human.Fullname = "Bob Tiger";
//Human.Age = 21;
//Student Student = new Student();
//Student.Fullname = "Ron Watson";
//Student.Age = 32;
//Human.Info();
//Student.Info();
//Console.WriteLine(Human);
//Console.WriteLine(Student);

//abstract class Human
//{
//    //поле
//    public string name;

//    private string _fullname;
//    private int _age;
//    //свойство
//    public string Fullname
//    {
//        get => _fullname;
//        set { _fullname = value; }
//    }
//    public virtual int Age
//    {
//        get
//        {
//            return _age;
//        }
//        set { if (value > 0 && value < 110) _age = value; }
//    }

//    public virtual void Info()
//    {
//        Console.WriteLine($"Human - {Fullname} {Age} old");
//    }
//}

//class Student : Human
//{
//    public override int Age
//    {
//        get => base.Age;
//        set { if (value > 16 && value < 110) base.Age = value; }
//    }
//    public override void Info()
//    {
//        Console.WriteLine($"Student - {Fullname}");
//    }
//    public override string ToString()
//    {
//        return $"Student :\n Fullname - {Fullname}\n Age - {Age}";
//    }
//}

Transport transport = new Car();
List<Transport> lst = new List<Transport>();
lst.Add(new Car());
lst.Add(new Ship());
lst.Add(new Aircraft());
foreach(var i in lst)
{
    i.Move();
}
abstract class Transport
{
    public abstract void Move();
}
// класс корабля
class Ship : Transport
{
    // мы должны реализовать все абстрактные методы и свойства базового класса
    public override void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
}
// класс самолета
class Aircraft : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолет летит");
    }
}
// класс машины
class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
}
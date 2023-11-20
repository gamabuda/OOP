try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
    if(y < 0)
    {
        throw new Exception("");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Блок finally");
}
Console.WriteLine("Конец программы");

//Dictionary<int, string> people = new 
//Dictionary<int, string>();

//people = new Dictionary<int, string>()
//{
//    { 5, "Tom"},
//    { 3, "Sam"},
//    { 11, "Bob"}
//};
//people[1] = "Bob";
//people.Add(2, "dfdf");
//people.Clear();
//people.ContainsKey(1);
//people.Remove(1);
//foreach (var person in people)
//{
//    Console.WriteLine($"key: " +
//        $"{person.Key}  value: " +
//        $"{person.Value}");
//}















//using OOP.ForestExample;
//Console.WriteLine("Гномья сортировка");
//Console.Write("Введите элементы массива: ");
//var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
//var array = new int[parts.Length];
//for (int i = 0; i < parts.Length; i++)
//{
//    array[i] = Convert.ToInt32(parts[i]);
//}

//Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", GnomeSort(array)));

//Console.ReadLine();

//static void Swap(ref int item1, ref int item2)
//{
//    var temp = item1;
//    item1 = item2;
//    item2 = temp;
//}

////Гномья сортировка
//static int[] GnomeSort(int[] unsortedArray)
//{
//    var index = 1;
//    var nextIndex = index + 1;

//    while (index < unsortedArray.Length)
//    {
//        if (unsortedArray[index - 1] < unsortedArray[index])
//        {
//            index = nextIndex;
//            nextIndex++;
//        }
//        else
//        {
//            Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
//            index--;
//            if (index == 0)
//            {
//                index = nextIndex;
//                nextIndex++;
//            }
//        }
//    }

//    return unsortedArray;
//}


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

//Transport transport = new Car();
//List<Transport> lst = new List<Transport>();
//lst.Add(new Car());
//lst.Add(new Ship());
//lst.Add(new Aircraft());
//foreach(var i in lst)
//{
//    i.Move();
//}
//abstract class Transport
//{
//    public abstract void Move();
//}
//// класс корабля
//class Ship : Transport
//{
//    // мы должны реализовать все абстрактные методы и свойства базового класса
//    public override void Move()
//    {
//        Console.WriteLine("Корабль плывет");
//    }
//}
//// класс самолета
//class Aircraft : Transport
//{
//    public override void Move()
//    {
//        Console.WriteLine("Самолет летит");
//    }
//}
//// класс машины
//class Car : Transport
//{
//    public override void Move()
//    {
//        Console.WriteLine("Машина едет");
//    }
//}
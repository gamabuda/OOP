Human Human = new Human();
Human.Fullname = "Bob Tiger";
Human.Age = 21;
Student Student = new Student();
Student.Fullname = "Ron Watson";
Student.Age = 32;
Human.Info();
Student.Info();
Console.WriteLine(Human);
Console.WriteLine(Student);

class Human
{
    //поле
    public string name;

    private string _fullname;
    private int _age;
    //свойство
    public string Fullname 
    { 
        get => _fullname; 
        set{ _fullname = value; }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public virtual void Info()
    {
        Console.WriteLine($"Human - {Fullname} {Age} old");
    }
}

class Student : Human
{
    public override void Info()
    {
        Console.WriteLine($"Student - {Fullname}");
    }
    public override string ToString()
    {
        return $"Student :\n Fullname - {Fullname}\n Age - {Age}";
    }
}
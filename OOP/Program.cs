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
    public virtual int Age
    {
        get
        {
            return _age;
        }
        set { if (value > 0 && value < 110) _age = value; }
    }

    public virtual void Info()
    {
        Console.WriteLine($"Human - {Fullname} {Age} old");
    }
}

class Student : Human
{
    public override int Age
    {
        get => base.Age;
        set { if (value > 16 && value < 110) base.Age = value; }
    }
    public override void Info()
    {
        Console.WriteLine($"Student - {Fullname}");
    }
    public override string ToString()
    {
        return $"Student :\n Fullname - {Fullname}\n Age - {Age}";
    }
}
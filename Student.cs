class Student : Person
{
    public Student(string name, int age, string schoolName) //Конструктор класса Student (ctor при наборе)// инициализация через класс person:
    : base(name, age)
    {
        this.SchoolName = schoolName;
    }
    public string SchoolName { get; set; }  //быстрый набор prop - генерация быстрая свойства класса

    public override string StringToPrint() //из виртуального метода можно в данном классе скорректировать свой через override
    {
        return base.StringToPrint() + $" Школа: {this.SchoolName};";
    }
}
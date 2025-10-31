class Employee : Person
{
    public Employee(string name, int age, int salary) //Конструктор класса Student (ctor при наборе)// инициализация через класс person:
    : base(name, age)
    {
        this.Salary = salary;
    }
    public int Salary { get; set; }  //быстрый набор prop - генерация быстрая свойства класса

    public override string StringToPrint() //из виртуального метода можно в данном классе скорректировать свой через override
    {
        return base.StringToPrint() + $" Зарплата: {this.Salary};";
    }
}
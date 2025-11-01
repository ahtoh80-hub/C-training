class Teacher : Person
{
    public Teacher(string name, int age, string subject) //Конструктор класса Student (ctor при наборе)// инициализация через класс person:
    : base(name, age)
    {
        this.Subject = subject;
    }
    public string Subject { get; set; }  //быстрый набор prop - генерация быстрая свойства класса

    public override string StringToPrint() //из виртуального метода можно в данном классе скорректировать свой через override
    {
        return base.StringToPrint() + $" Предмет: {this.Subject};";
    }
    //тренировка по возвращению параметров через класс Person
    public override string Return() //Виртуальный метод может быть переопределен в классах наследниках!!!!
    {
        return this.Subject;
    }
}
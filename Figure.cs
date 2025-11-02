abstract class Figure 
{
    //конструктор заполнения класса Figure() - всегда совпадает по имени с классом (инициализация)
    public Figure()
    {
    }
    //Свойства класса Figure:
    //количество сторон фигуры добавить:

    public double Square {  get => GetSquare() ; }// площадь фигуры
    public abstract string TypeFigure { get; } // тип фигуры "Circle", "triangle", "square" 

    //Абстрактный метод расчет площади фигуры:
       public virtual double GetSquare() //Виртуальный метод может быть переопределен в классах наследниках!!!!
    {
       return this.Square;
    }
    
    //Метод формирования string переменной для печати площади фигуры:
    public virtual string PrintSquare() //Виртуальный метод может быть переопределен в классах наследниках!!!!
    {
        return $"Фигура {this.TypeFigure} имеет площадь: {this.Square};";
    }
}
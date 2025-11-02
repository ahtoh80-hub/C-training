class Circle : Figure
{
    public Circle(double radius) //Конструктор класса Student (ctor при наборе)// инициализация через класс person:
   // : base(typeFigure,Square)
    {
        this.Radius = radius;
  
    }

    public double Radius { get; set; }  //свойство радиус круга

    public override string TypeFigure //абстрактное свойство меняется в конкретном классе:
    { 
        get => "Circle";
    }

//метод получения площади круга
    public override double GetSquare() 
    {
       return Math.PI*Math.Pow(this.Radius,2);
    }

    public override string PrintSquare() //метод формирования строки для печати результатов
    {
        return base.PrintSquare();
    }


}
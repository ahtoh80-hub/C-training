class Triangle : Figure
{
    public Triangle(double side1,double side2,double side3) //Конструктор класса Student (ctor при наборе)// инициализация через класс person:
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }
    public double Side1 { get; set; }  //свойство радиус круга
    public double Side2 { get; set; }  //свойство радиус круга
    public double Side3 { get; set; }  //свойство радиус круга

    public override string TypeFigure //абстрактное свойство меняется в конкретном классе:
    { 
        get => GetTypeFigure();
    }

public string GetTypeFigure() 
{
 if (((Side1+Side2)>Side3)&&((Side1+Side3)>Side2)&&((Side2+Side3)>Side1))
 {
    return "Triangle";
 }
 else
 {
    return "Not Triangle";
 }
}

//метод получения площади круга
    public override double GetSquare() 
    {
    if (TypeFigure=="Triangle")
    {
    double P=(Side1+Side2+Side3)/2;
    return Math.Sqrt(P*(P-Side1)*(P-Side2)*(P-Side3));
    }
    else
    {
    return 0;
    }
    }

    public override string PrintSquare() //метод формирования строки для печати результатов
    {
        return base.PrintSquare();
    }


}
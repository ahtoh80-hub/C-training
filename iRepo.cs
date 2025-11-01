interface iRepo<T>
{
    int Index { get; }
    void Append(params Person[] people);// методы в интерфейсе не описываются (Метод добавления)
    public T GetById(int id); //Метод получения данных типа Person из репозитория по номеру id
}

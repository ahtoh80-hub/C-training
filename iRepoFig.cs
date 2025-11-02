interface iRepoFig<T>
{
    int Index { get; }
    void Append(params Figure[] figure);// (Метод добавления)
    public T GetById(int id); 
    //Метод получения данных типа (T) из репозитория по номеру id
}

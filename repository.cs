//База данных (репозиторий)
class Repository
{
    private Person[] storage; // типа данных массив из класса Person (размер массива определяем в конструкторе класса Repository)
    private int count; //максимально количество записей в репозитории (количество записей определяем в конструкторе класса Repository)
    private int index; //номер следующей записи для записи (счетчик)

    public Repository(int count) //конструктор класса Repository
    {
        this.count = count; //this означает контекст текущего класса и имеется ввиду private int count;
        storage = new Person[count];
    }

    //3 способа как написать метод возвращения текущего количества записей Index для класса Printer
    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Index => index;

    //Метод массового заполнения Метод добавления данных типа Person в репозиторий и изменение счетчика index
    public void Append(params Person[] people)
    {
        foreach (var person in people)
        {
            if (this.index >= this.count) //Проверка превышения количества записей
            {
                Console.WriteLine($"Превышение количества записей: {this.count}");
                return;
            }
            else
            {
                storage[this.index] = person;
                this.index++;
            }
            //           this.Append(person); //можно метод Append просто сюда перенести;
        }
    }

    public Person GetPersonById(int id) //Метод получения данных типа Person из репозитория по номеру id
    {
        if (id < 0 || id >= this.index)
        {
            return new Person("Empty", -1);
        }
        return storage[id];
    }
}
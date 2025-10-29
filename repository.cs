//База данных (репозиторий)
class Repository
{
    private Person[] people; // типа данных массив из класса Person
    private int count; //максимально количество записей в репозитории
    private int index; //номер следующей записи для записи (счетчик)

    private int id; // номер записи для печати

    public Repository(int count) //конструктор класса Repository
    {
        this.count = count; //this означает контекст текущего класса и имеется ввиду private int count;
        people = new Person[count];
    }

    //3 способа как написать метод возвращения текущего количества записей Index для класса Printer
    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Index => index;

    public void Append(Person person) //Метод добавления данных типа Person в репозиторий и изменение счетчика index
    {
        if (this.index >= this.count) //Проверка превышения количества записей
        {
            Console.WriteLine($"Превышение количества записей: {this.count}");
            return;
        }
        else
        {
            people[this.index] = person;
            this.index++;
        }
    }

    public Person GetPersonById(int id) //Метод получения данных типа Person из репозитория по номеру id
    {
        if (id < 0 || id >= this.index)
        {
            return new Person("Empty", -1);
        }
        return people[id];
    }
}
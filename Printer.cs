class Printer // Печать всего репозитория
{
    public void Print(Repository repository)
    {
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Person TempPerson = repository.GetPersonById(i);
            Console.WriteLine($"Номер записи:{i}, Имя:{TempPerson.Name}, Возраст:{TempPerson.Age};");
        }
    }
}
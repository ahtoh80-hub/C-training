class Printer // Печать всего репозитория
{
    public void Print(Repository repository)
    {
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Person TempPerson = repository.GetPersonById(i); //промежуточная переменная типа Person для печати
            Console.WriteLine($"Номер записи:{i},{TempPerson.StringToPrint()}");
        }
    }
}
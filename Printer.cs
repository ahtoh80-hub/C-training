class Printer // Печать всего репозитория
{
    public void Print(iRepository repository)
    {
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Person TempPerson = repository.GetById(i); //промежуточная переменная типа Person для печати
            Console.WriteLine($"Номер записи:{i},{TempPerson.StringToPrint()}");
        }
    }
}
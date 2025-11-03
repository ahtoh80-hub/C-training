class PrinterFig // Печать всего репозитория
{
    public void Print(iRepositoryFig repository)
    {
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Figure TempFigure = repository.GetById(i); //промежуточная переменная типа Person для печати
            Console.WriteLine($"Номер записи:{i},{TempFigure.PrintSquare()}");
        }
    }
}
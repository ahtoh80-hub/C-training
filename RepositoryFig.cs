class RepositoryFig : iRepositoryFig
{
    public List<Figure> col;
    public RepositoryFig() //конструктор
    {
        col = new List<Figure>();
    }
    public int Index => col.Count;

    public void Append(params Figure[] figure)
    {
        foreach (var item in figure)
        {
            col.Add(item);
        }
    }
    public Figure GetById(int id)
    {
        return col[id];
    }
}
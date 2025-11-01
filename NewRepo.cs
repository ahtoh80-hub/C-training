class NewRepo : iRepository
{
    public List<Person> col;
    public NewRepo() //конструктор
    {
        col = new List<Person>();
    }
    public int Index => col.Count;

    public void Append(params Person[] people)
    {
        foreach (var item in people)
        {
            col.Add(item);
        }
    }
    public Person GetById(int id)
    {
        return col[id];
    }
}
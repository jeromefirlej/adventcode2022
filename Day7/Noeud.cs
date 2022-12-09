namespace Day7;
public class Noeud
{
    public Noeud(string currentrep)
    {
        Id = currentrep;
    }

    public string Id { get; }
    public Noeud? Parent;
    public List<Noeud> Childs { get; } = new ();
    public int Length { get; set; } = 0;

    private int _total;
    public int GetLength()
    {
        if (_total > 0)
            return _total;
        var total = Length;
        foreach (var child in Childs)
        {
            total += child.GetLength();
        }

        _total = total;
        return total;
    }
}
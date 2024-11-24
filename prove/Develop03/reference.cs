public class Reference
{
    private string _verse;

    public Reference(string verse)
    {
        _verse = verse;
    }

    public void Display()
    {
        Console.WriteLine(_verse);
    }
}

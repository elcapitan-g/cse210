public class Program
{
    public static void Main()
    {
        var scripture = new Scripture("1 Nephi 2:15", "'And my father dwelt in a tent.'");

        while (true)
        {
            scripture.Display(); 

            Console.WriteLine("You got this!");
            Console.WriteLine("Simply press Enter to hide a word, or type 'quit' to exit.");
          string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord(); 

            if (scripture.AllWordsHidden())
            {
                scripture.Display(); 
                Console.WriteLine("Great Work!");
                Console.WriteLine("All words are now hidden. Press Enter to exit.");
  
                Console.ReadLine();
                break;
            }
        }
    }
}

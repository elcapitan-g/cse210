public class Scripture
{
    private Reference _scriptureReference;
    private Word[] _words;

    public Scripture(string reference, string text)
    {
        _scriptureReference = new Reference(reference);
        string[] textWords = text.Split(' ');
        _words = new Word[textWords.Length];

        for (int i = 0; i < textWords.Length; i++)
        {
            _words[i] = new Word(textWords[i]);
        }
    }

    public void Display()
    {
        Console.Clear(); 
        _scriptureReference.Display();

        for (int i = 0; i < _words.Length; i++)
        {
            Console.Write(_words[i].IsHidden ? _words[i].Text : _words[i].Text + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int visibleCount = 0;

        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden)
                visibleCount++;
        }

        if (visibleCount > 0)
        {
            int randomIndex = random.Next(visibleCount);
            int hiddenCount = 0;

            for (int i = 0; i < _words.Length; i++)
            {
                if (!_words[i].IsHidden)
                {
                    if (hiddenCount == randomIndex)
                    {
                        _words[i].Hide();
                        break;
                    }

                    hiddenCount++;
                }
            }
        }
    }

    public bool AllWordsHidden()
    {
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden)
                return false;
        }

        return true;
    }
}

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public override string ToString()
    {
        return $"{_reference}: {_text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();
        for (int i = 0; i < numberOfWords; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }

            int index;
            do
            {
                index = random.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
}    
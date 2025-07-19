public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int textLength = _text.Length;
            return new string('_', textLength);
        }
        else
        {
            return _text;
        }
    }
}
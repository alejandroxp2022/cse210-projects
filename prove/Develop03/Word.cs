using System;

class Word
{
    private string _word;
    private bool _ishidden = false;

    public Word()
    {
        _word = "";
    }
    public Word(string word)
    {
        _word = word;
    }

    public void setWord(string word)
    {
        _word = word;
    }
    public void hideWordcita()
    {
        //string[] _wordChars = word.Split("");
        //Console.WriteLine("beforeHide: " + _word);
        foreach ( char charw in _word)
        {
            if (char.IsLetter(charw))
            {
                _word = _word.Replace(charw,  '_' );
            }
        }
        _ishidden = true;
        //Console.WriteLine("afterHide: " + _word);

    }
    public string toString()
    {
        return $"{_word}";
    }

    public bool isHiddenWord()
    {
        return _ishidden;
    }


}
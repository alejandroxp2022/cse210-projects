using System;
using System.Collections.Generic;

class Scripture
{
    private string scripture;
    private string scriptureout;
    private List<Word> wordList = new List <Word> ();
    private int countingHidden = 0;
    private bool _ishidenscripture = false;

    private int _words_count = 0 ;
    
    public Scripture()
    {
        scripture = "";
    
    }
   public Scripture(string scriptxt)
    {
        scripture = scriptxt;
    
    }
    public void hideWord()
    {

        //int counter = wordList.Count();
        Random rand = new Random();
        int position = rand.Next(_words_count);
        bool hiding = false;
        
        do 
        {
           if(! wordList[position].isHiddenWord()) 
           {
               wordList[position].hideWordcita(); 
               hiding = true;
           }
        } while (!hiding);
        
    }


    public string toString()
    {
        scriptureout = "";
        hideWord();
        foreach( Word _word in wordList)
        {
            scriptureout = scriptureout + " " + _word.toString();
        }
        return scriptureout;
    }
    public void setScripture ( string scripture)
    {
        string[] scriptureList = scripture.Split(" ");
        foreach ( string _word in scriptureList)
        {
            Word _wordcita = new Word(_word);
            wordList.Add(_wordcita); 
        }
        _words_count = wordList.Count();
    }

    public bool isHiddenScripture()
    {
        countingHidden = 0;
        foreach( Word _wordcita in wordList)
            {
                if( _wordcita.isHiddenWord()){
                    countingHidden += 1;
                }
            }
        if ( _words_count <= countingHidden){
            _ishidenscripture = true; 
        }
        return _ishidenscripture;
    }


}
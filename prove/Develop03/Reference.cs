using System;
using System.Text.RegularExpressions;

class Reference
{
    private string _book;
    private string _chapter;
    private string _initverse ;
    private string _finverse ;

        //Console.WriteLine("Hello Develop03 World!");
    public Reference()
    {
        _book="";
        _chapter= "";
        _initverse = "";
        _finverse = "";
    }
    public Reference(string book)
    {
        _book= book;
        _chapter= "";
        _initverse = "";
        _finverse = "";
    }
    public Reference(string book, string chapter)
    {
        _book= book;
        _chapter= chapter;
        _initverse = "";
        _finverse = "";
    }
    public Reference(string book, string chapter, string initverse)
    {
        _book= book;
        _chapter= chapter;
        _initverse = initverse;
        _finverse = "";
    }
    public Reference(string book, string chapter, string initverse, string finverse)
    {
        _book= book;
        _chapter= chapter;
        _initverse = initverse;
        _finverse = finverse;
    }
    public string toString()
    {
        string _colon = "";
        if  ( _finverse != "" ) { _colon = ":";} 
        return "" + _book + " " + _chapter + ":" + _initverse + _colon + _finverse;   
    }
    public void setReference ( string _reference)
    {
        String[] bookList = _reference.Split(" ");
        _book = bookList[0];
        String[] chapterList =bookList[1].Split(":");
        _chapter = chapterList[0];
        String[] verseList = chapterList[1].Split("-");
        _initverse = verseList[0];
        Regex rgx = new Regex(@"^\s*-\d{1-2}");
        
        if ( rgx.IsMatch(_reference))
        {
            _finverse = verseList[1];
        }
        
    }
}
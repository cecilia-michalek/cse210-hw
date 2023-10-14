using System;

public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

public Reference() {
    _book = "";
    _chapter = null;
    _startVerse = null;
    _endVerse = null;
}
public Reference(string _book, int _chapter, int _startVerse) {
    _book = "Proverbs";
    _chapter = 3;
    _startVerse = 4;
    _endVerse = null;
}
public Reference(string _book, int _chapter, int _startVerse, int _endVerse) {
    _book = "Proverbs";
    _chapter = 3;
    _startVerse = 4;
    _endVerse = 6;
}
public string GetSingleVerse(){
    foreach (Reference reference in references)
            {
                writer.WriteLine($"{reference.book}, {entry.Chapter}, {entry.startVerse}");
                writer.WriteLine();
            }
}
GetMultiVerse(): String

}
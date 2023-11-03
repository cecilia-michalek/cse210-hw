using System;
//Base Class
public class Music {
    protected string _singersName = "";
    protected string _song = "";
    public Music(string singersName, string song) {
        _singersName = singersName;
        _song = song;
    }
}
//Derice Class
public class Genre : Music {
    private int _year;
    private string _producer;
    public Genre (string singersName, string song, string producer, int year) : base(singersName, song){
        _year = year;
        _producer = producer;
    }
    public string GetMusicInfo(){
        
        return $"{_singersName} - {_song} - {_year} - {_producer}";
    }
}
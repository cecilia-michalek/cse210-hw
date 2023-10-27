using System;

public class WritingAssignment : Assingnment {
    private string _bookChapter = "";
    private string _writing = "";

    public WritingAssignment(): base(){
        _bookChapter = "Chapter 1";
        _writing = "summery";
    }
    public WritingAssignment(string studentName, string topic, string bookChapter, string writing) : base(studentName, topic){
        _bookChapter = bookChapter;
        _writing = writing;
    }
    public string GetWritingAssignmentInfo(){
        
        return $"{_studentName} - {_topic} - {_bookChapter} - {_writing}";
    }
    //public void SetWritingAssingnment(string bookChapter, string writing) {
        //_bookChapter = bookchapter;
        //_writing = writing;
        
    //}

    
}

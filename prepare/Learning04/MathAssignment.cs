using System;

public class MathAssignment : Assingnment {
    private string _textbookSection = "";
    private string _problems = "";
    

    public MathAssignment(): base(){
        _textbookSection = "Seccion1";
        _problems = "1-3";
    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
        
    
    public string GetMathAssignmentInfo(){
        
        return $"{_studentName} - {_topic} - {_textbookSection} - {_problems}";
    }
    public void SetMathAssignmentInfo(string textbookSection, string problems) {
        _textbookSection = textbookSection;
        _problems = problems;

    
}}

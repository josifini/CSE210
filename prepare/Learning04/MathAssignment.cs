using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // public string GetTextbookSection()
    // {
        // return _textbookSection;
    // }

    // public void SetTextbookSection(string textbookSection)
    // {
        // _textbookSection = textbookSection;
    // }

    // public string GeProblems()
    // {
        // return _problems;
    // }
    // public void SetProblems(string problem)
    // {
        // _problems = problem;
    // }

//     public string GetHomeworkList()

//     {
//         return $"Section {_textbookSection} Problems {_problems}";
//         // return $"{_textbookSection} by {_problems}";
//     }


// }
public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
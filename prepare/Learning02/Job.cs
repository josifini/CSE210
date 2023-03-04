using System;

public class Job
{
    public string _jobTitle;
    public string _jobcompany;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobcompany}) {_startYear}-{_endYear}");
    }    

}
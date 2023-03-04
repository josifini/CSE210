using System;

public class Resume
{
    public string _name;

//List of jobs

    public List<Job> _jobs = new List<Job>();

    public void Display()

    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {

            
            //This calls Display method on each job
            job.Display();
        }
    }


}
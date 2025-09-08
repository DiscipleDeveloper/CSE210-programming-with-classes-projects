public class Resume
{
    public string _name;
    private List<Job> jobs = new List<Job>();

    public List<Job> Jobs { get => jobs; set => jobs = value; }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
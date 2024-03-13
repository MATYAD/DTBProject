namespace DatabaseProject.Entities;

public class Project
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Project(int id, string name, string description, DateTime startDate, DateTime endDate)
    {
        ID = id;
        Name = name;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
    }

    public Project()
    {
        
    }
    
 }
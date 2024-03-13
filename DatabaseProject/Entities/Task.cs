namespace DatabaseProject.Entities;

public class Task
{
    public int ID { get; set; }
    public string Description { get; set; }
    public int AssignedEmployeeID { get; set; }
    public int ProjectID { get; set; }
    public string Status { get; set; }

    public Task(int id, string description, int employeeID, int projectID, string status)
    {
        ID = id;
        Description = description;
        AssignedEmployeeID = employeeID;
        ProjectID = projectID;
        Status = status;
        
    }

    public Task()
    {
        
    }
    
    
}
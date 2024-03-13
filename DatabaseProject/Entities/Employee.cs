namespace DatabaseProject.Entities;

public class Employee
{
    public int ID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime StartDate { get; set; }
    public float Salary { get; set; }
    public Boolean IsActive { get; set; }

    public Employee(int iD, string firstName, string lastName, DateTime startDate, float salary, Boolean isActive)
    {
        ID = iD;
        FirstName = firstName;
        LastName = lastName;
        StartDate = startDate;
        Salary = salary;
        IsActive = isActive;
    }

    public Employee()
    {
        
    }

    
    
}
namespace SchoolDB.Core.Models;

/// <summary>
/// Variables:
/// StaffId, FirstName, LastName, Email,
/// Phone, Role, Department, HireDate, IsActive
/// </summary>
public class Staff
{
    public int StaffId { get; private set; }
    public string FirstName{ get; private set; }
    public string LastName{ get; private set; }
    public string Email{ get; private set; }
    public int Phone{ get; private set; }
    public string Role{ get; private set; }
    public string Department{ get; private set; }
    public DateTime HireDate{ get; private set; }
    public bool IsActive{ get; private set; }


    protected Staff() { }

    public Staff(int staffId, string firstName, string lastName, string email, int phone, string role,
        DateTime hireDate)
    {
        StaffId = staffId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Role = role;
        HireDate = hireDate;
        IsActive = true;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public void Deactivate()
    {
        IsActive = false;
    }


}
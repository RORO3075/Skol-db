namespace SchoolDB.Core.DTOs.Staff;
/// <summary>
/// Variables:
/// FirstName, LastName, Email,
/// Phone, Role, Department, HireDate
/// </summary>
public class StaffCreateDto
{
    public string FirstName{ get;  set; }
    public string LastName{ get;  set; }
    public string Email{ get;  set; }
    public int Phone{ get;  set; }
    public string Role{ get; set; }
    public string Department{ get;  set; }
    public DateTime HireDate{ get;  set; }
}
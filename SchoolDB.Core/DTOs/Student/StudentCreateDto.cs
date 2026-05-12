namespace SchoolDB.Core.DTOs.Student;
/// <summary>
/// Variables:
/// FirstName, LastName, Email,
/// DateOfBirth, EnrollmentDate, GradeLevel,
/// GuardianName, GuardianContact
/// </summary>
public class StudentCreateDto
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime EnrollmentDate { get;  set; }
    public int GradeLevel { get; set; }
    public string GuardianName { get;  set; }
    public string GuardianContact { get; set; }

}
namespace SchoolDB.Core.DTOs.Student;
/// <summary>
/// Variables:
/// FirstName, LastName, Email,
/// DateOfBirth, EnrollmentDate, GradeLevel
/// </summary>
public class StudentResponseDto
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime EnrollmentDate { get;  set; }
    public int GradeLevel { get; set; }

}
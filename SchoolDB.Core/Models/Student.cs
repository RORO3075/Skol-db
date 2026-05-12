namespace SchoolDB.Core.Models;
/// <summary>
/// Variables:
/// StudentId, FirstName, LastName, Email,
/// DateOfBirth, EnrollmentDate, GradeLevel,
/// GuardianName, GuardianContact, IsActive
/// </summary>
public class Student
{
    public int StudentId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public DateTime EnrollmentDate { get; private set; }
    public int GradeLevel { get; private set; }
    public string GuardianName { get; private set; }
    public string GuardianContact { get; private set; }
    public bool IsActive { get; private set; }

    protected Student() { }

    public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth, DateTime enrollmentDate,
        int gradeLevel, string guardianName, string guardianContact)
    {
        StudentId = studentId;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        EnrollmentDate = enrollmentDate;
        GradeLevel = gradeLevel;
        GuardianName = guardianName;
        GuardianContact = guardianContact;
        IsActive = true;
    }

    public string FullName ()
    {
        return $"{FirstName} {LastName}";
    }

    public void Deactivate()
    {
        IsActive = false;
    }
    public void UpdateGuardian(string newGuardianName , string newGuardianContact)
    {
        GuardianName = newGuardianName;
        GuardianContact = newGuardianContact;
    }
}
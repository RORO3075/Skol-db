namespace SchoolDB.Core.DTOs.Academics;
/// <summary>
/// Variables:
/// StudentFirstName, StudentLastName, CourseName , Date , Status
/// </summary>
public class AttendanceDto
{
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public string CourseName { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
}
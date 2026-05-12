namespace SchoolDB.Core.Models;
/// <summary>
/// Variables:
/// AttendanceId, StudentId, CourseId, Date, Status
/// </summary>
public class Attendance
{
    public int AttendanceId { get; private set; }
    public int StudentId { get; private set; }
    public int CourseId { get; private set; }
    public DateTime Date { get; private set; }
    public char Status { get; private set; }

}
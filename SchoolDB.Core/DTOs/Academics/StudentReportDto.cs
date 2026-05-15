using System.Globalization;

namespace SchoolDB.Core.DTOs.Academics;
/// <summary>
///StudentReportDto
// int          StudentId
// string       FullName
// int          GradeLevel
// string       EnrollmentDate
//
// List<CourseResultDto>       Courses
// List<AttendanceSummaryDto>  AttendanceSummary
//
//
// CourseResultDto
// int          CourseId
// string       CourseName
// string       AssignedTeacherName
// string       Term
// double       Score
// string       GradeLetter
//
//
// AttendanceSummaryDto
// int          CourseId
// string       CourseName
// int          TotalClasses
// int          Present
// int          Absent
// int          Late
/// </summary>
public class StudentReportDto
{
    public int StudentId { get; set; }
    public string FullName { get; set; }
    public int GradeLevel { get; set; }
    public DateTime EnrollmentDate { get; set; }
}

internal class CourseResultDto
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string AssignedTeacherName { get; set; }
    public string Term { get; set; }
    public double Score { get; set; }
    public string GradeLetter { get; set; }
}

internal class AttendanceSummaryDto
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int TotalClasses { get; set; }
    public int Present { get; set; }
    public int Absent { get; set; }
    public int Late {  get; set; }
}
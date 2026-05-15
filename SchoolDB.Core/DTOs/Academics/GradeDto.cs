namespace SchoolDB.Core.DTOs.Academics;
/// <summary>
/// Variables:
/// StudentFirstName, StudentLastName, CourseName,
/// Term, Score, GradeLetter
/// </summary>
public class GradeDto
{
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public string CourseNamer { get; set; }
    public string Terms { get; set; }
    public double Score {  get; set; }
    public string GradeLetter { get; set; }
}
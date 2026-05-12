namespace SchoolDB.Core.Models;
/// <summary>
/// Variables:
/// CourseId, Name, Description,
/// AssignedStaffId, GradeLevel, Credits
/// </summary>
public class Course
{
    public int CourseId { get; private set; }
    public string Name{ get; private set; }
    public string Description { get; private set; }
    public int AssignedStaffId{ get; private set; }
    public int GradeLevel{ get; private set; }
    public int Credits{ get; private set; }

    protected Course() { }

    public Course(int courseId, string name, string description, int gradeLevel, int credits)
    {
        CourseId = courseId;
        Name = name;
        Description = description;
        GradeLevel = gradeLevel;
        Credits = credits;
    }

}
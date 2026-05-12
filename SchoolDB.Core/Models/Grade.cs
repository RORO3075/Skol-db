namespace SchoolDB.Core.Models;
/// <summary>
/// Variables:
/// GradeId, StudentId, CourseId,
/// Term, Score, GradeLetter
/// </summary>
public class Grade
{
    public int GradeId { get; private set; }
    public int StudentId  { get; private set; }
    public int CourseId{ get; private set; }
    public string Term{ get; private set; }
    public int Score{ get; private set; }
    public char GradeLetter{ get; private set; }

    public Grade(int gradeId, int studentId, int courseId, string term, int score)
    {
        GradeId = gradeId;
        StudentId = studentId;
        CourseId = courseId;
        Term = term;
        Score = score;
        GradeLetter = score switch
        {
            >= 90 => 'S',
            >= 80 => 'A',
            >= 70 => 'B',
            >= 60 => 'C',
            >= 50 => 'D',
            >= 40 => 'E',
            >= 0 => 'F',
            _ => throw new ArgumentOutOfRangeException(nameof(score), score, null)
        };
    }
}
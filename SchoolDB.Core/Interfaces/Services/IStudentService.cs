namespace SchoolDB.Core.Interfaces.Services;
/// <summary>
/// Talks to: StudentRepository

// Methods:
// EnrollNewStudent(studentData)       → validates age/grade, calls repo.Add()
// UpdateStudentInfo(studentData)      → validates, calls repo.Update()
// GraduateStudent(studentId)          → calls repo.Deactivate()
// GetStudentProfile(studentId)        → returns Student
// GetStudentsByGrade(gradeLevel)      → returns List<Student>
/// </summary>
public interface IStudentService
{
    
}
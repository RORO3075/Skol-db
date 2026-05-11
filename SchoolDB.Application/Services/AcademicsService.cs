namespace SchoolDB.Application.Services;
/// <summary>
/// Talks to: CourseRepository, EnrollmentRepository,
// GradeRepository, AttendanceRepository,
// StudentRepository, StaffRepository
//
// Methods:
// CreateCourse(courseData)
// → checks staff exists and is a Teacher, calls CourseRepo.Add()
//
// AssignTeacherToCourse(staffId, courseId)
// → checks staff role, calls CourseRepo.Update()
//
// EnrollStudentInCourse(studentId, courseId)
// → checks grade level matches course, calls EnrollmentRepo.Enroll()
//
// RecordGrade(studentId, courseId, term, score)
// → calculates grade letter, calls GradeRepo.AddOrUpdate()
//
// MarkAttendance(courseId, date, attendanceList)
// → loops through list, calls AttendanceRepo.MarkAttendance()
//
// GetStudentReport(studentId)
// → calls GradeRepo + AttendanceRepo + EnrollmentRepo
// → assembles full picture of one student's academics
//
// GetCourseRoster(courseId)
// → calls EnrollmentRepo.GetByCourse() → then StudentRepo per id
/// </summary>
public class AcademicsService
{
    
}
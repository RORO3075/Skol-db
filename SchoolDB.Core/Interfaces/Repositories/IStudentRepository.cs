using SchoolDB.Core.Models;
namespace SchoolDB.Core.Interfaces.Repositories;

/// <summaru>
// Methods:
// GetById(studentId)        → Student
// GetAll()                  → List<Student>
// GetByGradeLevel(grade)    → List<Student>
// Add(student)              → void
//     Update(student)           → void
//     Deactivate(studentId)     → void
/// </summary>
public interface IStudentRepository
{
    Task<Student?> GetById(int id);
    Task<List<Student>> GetAll();
    Task<List<Student>> GetByGradeLevel(int gradeLevel);
    Task Add(Student student);
    Task Update(Student student);
    Task Deactivate(int id);
}
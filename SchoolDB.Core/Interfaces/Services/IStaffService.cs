namespace SchoolDB.Core.Interfaces.Services;
/// <summary>
// Methods:
// HireStaff(staffData)           → validates role/email, calls repo.Add()
// UpdateStaffInfo(staffData)     → validates, calls repo.Update()
// FireStaff(staffId)             → calls repo.Deactivate()
// GetStaffProfile(staffId)       → returns Staff
// GetAllTeachers()               → filters by role = Teacher
/// </summary>
public interface IStaffService
{
    
}
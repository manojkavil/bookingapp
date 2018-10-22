using HappierLiving.Appointment.Repository;
using System;
using System.Threading.Tasks;

namespace HappierLiving.Appointment.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }       
        public int DeleteStudent(int Id)
        {
            return _repo.Delete(Id);
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _repo.DeleteAsync(Id);
        }
    }
}

using HappierLiving.Appointment.Entity;
using Microsoft.Extensions.Configuration;

namespace HappierLiving.Appointment.Repository
{
    public class StudentRepository: BaseRepository<StudentEntity>, IStudentRepository
    {
        public StudentRepository(IConfiguration config) :base(config)
        {
             
        }
        
    }
    
}

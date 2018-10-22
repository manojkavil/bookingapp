using HappierLiving.Appointment.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HappierLiving.Appointment.Service
{
    public interface IStudentService
    {
        Task<int> DeleteStudentAsync(int Id);
        int DeleteStudent(int Id);
    }
}

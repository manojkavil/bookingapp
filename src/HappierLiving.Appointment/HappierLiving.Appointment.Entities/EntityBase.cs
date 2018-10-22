using System;

namespace HappierLiving.Appointment.Entity
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
    }

}

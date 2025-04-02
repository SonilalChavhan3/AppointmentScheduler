using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IAppointmentService
    {
        List<Appointment> GetUserAppointments(int userId);
        Task<bool> ScheduleAppointmentAsync(Appointment appointment);
    }
}

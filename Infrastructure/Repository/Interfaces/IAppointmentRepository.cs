using Domain.Entities;

namespace Infrastructure.Repository.Interfaces
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAppointmentsByUserId(int userId);

        Task<bool> CreateAppointmentAsync(Appointment appointment);
    }
}

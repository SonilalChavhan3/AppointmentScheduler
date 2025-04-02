using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using Application.Services.Interfaces;
namespace Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public List<Appointment> GetUserAppointments(int userId)
        {
            return  _repository.GetAppointmentsByUserId(userId);
        }

        public async Task<bool> ScheduleAppointmentAsync(Appointment appointment)
        {
            return await _repository.CreateAppointmentAsync(appointment);
        }
    }
}

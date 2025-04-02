using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Appointment> GetAppointmentsByUserId(int userId)
        {
            return  _context.Appointments.Where(a => a.UserId == userId).ToList();
        }

        public async Task<bool> CreateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

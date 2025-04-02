using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public  IActionResult Index()
        {
            //var appointments =  _appointmentService.GetUserAppointments(1); // Example UserId
            //return View(appointments);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Schedule(Appointment appointment)
        {
            if (await _appointmentService.ScheduleAppointmentAsync(appointment))
            {
                return RedirectToAction("Index");
            }
            return View(appointment);
        }
    }
}

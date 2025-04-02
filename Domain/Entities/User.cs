namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // User, Manager
        public List<Appointment> Appointments { get; set; } = new();
    }
}

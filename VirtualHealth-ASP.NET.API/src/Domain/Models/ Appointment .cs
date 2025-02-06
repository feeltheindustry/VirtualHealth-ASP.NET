

using System.ComponentModel.DataAnnotations;
using VirtualHealth_ASP.NET.API.src.Domain.Enums;


namespace VirtualHealth_ASP.NET.API.src.Domain.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public AppointmentStatus Status { get; set; }
        public ConsultationType ConsultationType { get; set; }
        public string? Notes { get; set; }
        public string? PrescriptionUrl { get; set; }
    }
}
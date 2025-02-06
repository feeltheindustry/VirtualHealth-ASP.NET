

using System.ComponentModel.DataAnnotations;

namespace VirtualHealth_ASP.NET.API.src.Domain.Models
{
    public class MedicalRecord
    {

        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string? Prescription { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
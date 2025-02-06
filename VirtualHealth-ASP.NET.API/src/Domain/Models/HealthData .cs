using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VirtualHealth_ASP.NET.API.Domain.Enums;

namespace VirtualHealth_ASP.NET.API.Domain.Models
{
    public class HealthData 
    {
    [Key]
    public int Id { get; set; }
    public int PatientId { get; set; }
    public HealthDataType DataType { get; set; }
    public string Value { get; set; }
    public DateTime Date { get; set; }
        
    }
}
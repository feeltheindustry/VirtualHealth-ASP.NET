using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VirtualHealth_ASP.NET.API.Domain.Enums;

namespace VirtualHealth_ASP.NET.API.Domain.Models
{
    public class  Notification
    {
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
    public NotificationType Type { get; set; }
    public NotificationStatus Status { get; set; }
    }
}
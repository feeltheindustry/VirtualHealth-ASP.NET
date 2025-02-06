
using System.ComponentModel.DataAnnotations;
using VirtualHealth_ASP.NET.API.src.Domain.Enums;

namespace VirtualHealth_ASP.NET.API.src.Domain.Models
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
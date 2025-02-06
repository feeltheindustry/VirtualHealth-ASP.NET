using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using VirtualHealth_ASP.NET.API.Domain.Enums;

namespace VirtualHealth_ASP.NET.API.Domain.Models
{
    public class AppUser :  IdentityUser
    {
    
     [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Specialization { get; set; }
    public string? Bio { get; set; }
    public string? ContactDetails { get; set; }
        
    }
}
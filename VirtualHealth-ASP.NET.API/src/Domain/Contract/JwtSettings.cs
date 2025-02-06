

namespace VirtualHealth_ASP.NET.API.Domain.Contract
{
      public class JwtSettings
    {
        public string? Key { get; set; }
        public string ValidIssuer { get; set; } 
        public string ValidAudience { get; set; }
        public double Expires { get; set; }


    }
}
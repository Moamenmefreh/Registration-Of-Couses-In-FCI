using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Registration.Models
{
    
    public class RefreshToken
    {

      
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpireOn { get; set; }

        public bool IsExpired =>DateTime.UtcNow>=ExpireOn;
        public DateTime CreateOn { get; set; }
        public DateTime? RevokedOn { get; set; }
        public bool IsActive=> RevokedOn==null&& !IsExpired;
       public IdentityUser User { get; set; }
    }
}

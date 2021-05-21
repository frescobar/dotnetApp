using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
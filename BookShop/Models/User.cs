using Microsoft.AspNetCore.Identity;

namespace BookShop.Models
{
    public class User : IdentityUser
    {
        public bool IsAdmin { get; set; }
        //public ICollection<Order> Orders { get; set; }
        //public ICollection<Feedback> Feedbacks { get; set; }
    }
}

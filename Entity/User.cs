using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Entity
{
    public class User : IdentityUser
    {
        public ICollection<UserCourse> UserCourses { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProjectPusher.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastNamr { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string Skill { get; set; }
        public string ProfileImag { get; set; }
        public int BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public bool IsOnline { get; set; }
        public bool IsOpenToBarter { get; set; }
        public string Bio { get; set; }
        public string ForSale { get; set; }
        public string LookingFor { get; set; }
        public string StatusMessage { get; set; }
    }
}

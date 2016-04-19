using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ImageApplication.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public DateTime MemberSince { get; set; }
        public DateTime LastLogin { get; set; }
    }
}

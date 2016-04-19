using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordDigest { get; set; }
        public string Role { get; set; }
        public DateTime MemberSince { get; set; }
        public DateTime LastLogin { get; set; }
       
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormApp.models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            RolestoUsers = new HashSet<RolestoUser>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RolestoUser> RolestoUsers { get; set; }
    }
}

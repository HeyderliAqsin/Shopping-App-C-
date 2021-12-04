using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormApp.models
{
    public partial class Role
    {
        public Role()
        {
            RolestoUsers = new HashSet<RolestoUser>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RolestoUser> RolestoUsers { get; set; }
    }
}

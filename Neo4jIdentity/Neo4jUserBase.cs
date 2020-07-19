using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Neo4jIdentity
{
    public abstract class Neo4jUserBase 
    {
        public Guid Id {get; set;}
        public string UserName {get; set;}
        public abstract string NormalizedUserName {get; set;}
        public System.Collections.Generic.IList<SimplifiedClaim> Claims { get; internal set; }
        public IList<UserLoginInfo> Logins { get; internal set; }
        public ICollection<Neo4jIdentityRole> Roles { get; internal set; }
        public LockoutInfo Lockout { get; internal set; }
    }
}
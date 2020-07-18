using System;

namespace Neo4jIdentity
{
    public abstract class Neo4jUserBase 
    {
        public Guid Id {get; set;}
        public string UserName {get; set;}
        public abstract string NormalizedUserName {get; set;}
    }
}
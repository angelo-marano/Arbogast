using System;
using System.Collections.Generic;

namespace Arbogast.Model
{
    public class Document
    {
        public Guid DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        IEnumerable<Entity> Entities { get; set;}
    }
}
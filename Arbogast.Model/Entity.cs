using System;
using System.Linq;
using System.Collections.Generic;

namespace Arbogast.Model
{
    public class Entity
    {
        public Entity(string name)
        {
            Name = name;
            EntityId = Guid.NewGuid();
            _documents = new HashSet<Document>();
        }

        internal Entity(Guid id, string name) : this(name)
        {
            EntityId = id;
        }

        public Guid EntityId { get; }
        public string Name { get; }
        internal HashSet<Document> _documents;
        IEnumerable<Document> Documents { get => _documents.ToArray(); }

    }
}
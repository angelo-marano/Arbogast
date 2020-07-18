using System;
using Arbogast.Model;

namespace Arbogast.Services 
{
    public interface IEntityService 
    {
        Entity GetEntity(Guid id);
        Entity AddEntity(Entity entity);
    }
}
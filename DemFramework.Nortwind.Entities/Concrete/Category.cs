using DemFramework.Core.Entities;

namespace DemFramework.Nortwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}

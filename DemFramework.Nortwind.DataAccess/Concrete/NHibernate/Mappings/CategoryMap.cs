using DemFramework.Nortwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DemFramework.Nortwind.DataAccess.Concrete.NHibernate.Mappings
{
    class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}

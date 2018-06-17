using DemFramework.Nortwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DemFramework.Nortwind.DataAccess.Concrete.NHibernate.Mappings
{
    class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProductId).Column("ProductID");
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
        }
    }
}

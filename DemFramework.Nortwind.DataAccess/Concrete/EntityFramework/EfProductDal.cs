using System.Collections.Generic;
using System.Linq;
using DemFramework.Core.DataAccess.EntityFramework;
using DemFramework.Nortwind.DataAccess.Abstract;
using DemFramework.Nortwind.Entities.ComplexTypes;
using DemFramework.Nortwind.Entities.Concrete;
using NHibernate.Loader.Custom.Sql;

namespace DemFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.CategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };
                return result.ToList();
            }
            
        }
    }
}

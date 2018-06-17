using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemFramework.Core.DataAccess.NHibernate;
using DemFramework.Nortwind.DataAccess.Abstract;
using DemFramework.Nortwind.Entities.ComplexTypes;
using DemFramework.Nortwind.Entities.Concrete;

namespace DemFramework.Nortwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NhEntityRepositoryBase<Product>,IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper ;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session= _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
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

using DemFramework.Core.DataAccess;
using DemFramework.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemFramework.Nortwind.Entities.ComplexTypes;

namespace DemFramework.Nortwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}

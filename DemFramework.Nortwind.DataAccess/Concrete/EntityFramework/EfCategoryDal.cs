using DemFramework.Core.DataAccess.EntityFramework;
using DemFramework.Nortwind.DataAccess.Abstract;
using DemFramework.Nortwind.Entities.Concrete;

namespace DemFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
    }
}

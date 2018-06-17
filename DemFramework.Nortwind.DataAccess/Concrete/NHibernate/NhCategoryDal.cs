using DemFramework.Core.DataAccess.NHibernate;
using DemFramework.Nortwind.DataAccess.Abstract;
using DemFramework.Nortwind.Entities.Concrete;

namespace DemFramework.Nortwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>,ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}

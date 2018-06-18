using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using DemFramework.Nortwind.Business.Abstract;
using DemFramework.Nortwind.Business.ValidationRules.FluentValidation;
using DemFramework.Nortwind.DataAccess.Abstract;
using DemFramework.Nortwind.Entities.Concrete;

namespace DemFramework.Nortwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidate(typeof(ProductValidatior))]
        public Product Add(Product product)
        {
            ValidatorTool.FluentValidate(new ProductValidatior(), product);
            return _productDal.Add(product);
        }

        [FluentValidate(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            ValidatorTool.FluentValidate(new ProductValidatior(), product);
            return _productDal.Update(product);
        }
    }
}

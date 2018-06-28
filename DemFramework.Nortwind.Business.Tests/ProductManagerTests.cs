using System;
using DemFramework.Nortwind.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DemFramework.Nortwind.Business.Concrete.Managers;
using DemFramework.Nortwind.Entities.Concrete;
using FluentValidation;

namespace DemFramework.Nortwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock=new Mock<IProductDal>();
            ProductManager productManager=new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}

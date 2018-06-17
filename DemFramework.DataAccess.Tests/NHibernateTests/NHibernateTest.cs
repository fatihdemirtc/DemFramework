﻿using DemFramework.Nortwind.DataAccess.Concrete.NHibernate;
using DemFramework.Nortwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal=new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList();

            Assert.AreEqual(77,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using System.Linq.Expressions;

namespace Xy.Pis.Service.UnitTests
{
    [TestClass]
    public class AutoMapperUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        { 
        }


        public abstract class Parent
        {
            public abstract int ID { get; set; }
        }

        public class Child //: Parent
        {
            public  int ID
            {
                get;
                set;
            }

            public string Name { get; set; }
        }

        public class ChildDTO
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }
    }
}

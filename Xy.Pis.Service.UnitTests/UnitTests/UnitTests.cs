using System;
using System.Linq.Expressions;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Core;

namespace Xy.Pis.Service.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_UnitTests_TestMethod1()
        {
        }

        public abstract class Parent
        {
            public abstract int ID { get; set; }
        }

        public class Child
        {
            public int ID
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

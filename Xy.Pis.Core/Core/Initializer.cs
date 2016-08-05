using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using System.Reflection;
using Xy.Pis.Common.Unity;

namespace Xy.Pis.Core
{
    public class Initializer
    {
        public static void Init<TDbContext>() where TDbContext : DbContext
        {
            IoC.RegisterType<DbContext, TDbContext>();
            IoC.RegisterType<IUnitOfWork, EFUnitOfWork<TDbContext>>();
        }
    }
}
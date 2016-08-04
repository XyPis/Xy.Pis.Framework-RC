using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using System.Reflection;

namespace Xy.Pis.Core
{
    public class Initializer
    {
        public static void Init<TDbContext>() where TDbContext : DbContext
        {
            Common.Unity.IoC.RegisterType<DbContext, TDbContext>();
            Common.Unity.IoC.RegisterType<IUnitOfWork, EFUnitOfWork<TDbContext>>();
        }
    }
}
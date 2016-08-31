using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.Practices.Unity;
using Xy.Pis.Utils.Unity;

namespace Xy.Pis.Core
{
    /// <summary>
    /// 数据库上下文和工作单元初始化类
    /// </summary>
    ///
    public class Initializer
    {
        /// <summary>
        /// 初始化数据库上下文和工作单元
        /// </summary>
        /// <typeparam name="TDbContext"></typeparam>
        public static void Init<TDbContext>(string connectionString) where TDbContext : DbContext
        {
            IoC.RegisterType<DbContext, TDbContext>(new InjectionConstructor(connectionString));
            IoC.RegisterType<IUnitOfWork, EFUnitOfWork<TDbContext>>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Core
{
    /// <summary>
    /// 事务选项
    /// </summary>
    public enum TransactionOption
    {
        /// <summary>
        /// 默认,由DBContext支持事务
        /// </summary>
        CTX = 0,

        /// <summary>
        /// 数据库连接级别事务
        /// </summary>
        DB = 1,

        /// <summary>
        /// 支持分布式事务
        /// </summary>
        DTC = 2,
    }
}

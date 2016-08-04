using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Core
{
    public enum TransactionOption
    {
        Default = 0, //默认,不开启新的事物
        Database = 1, //数据库级别的事务
        Distributed = 2, //分布式事务
    }
}

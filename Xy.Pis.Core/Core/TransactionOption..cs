using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Core
{
    public enum TransactionOption
    {
        None = 0, //默认,不开启新的事物
        DB = 1, //数据库级别的事务
        MSDTC = 2, //分布式事务
    }
}

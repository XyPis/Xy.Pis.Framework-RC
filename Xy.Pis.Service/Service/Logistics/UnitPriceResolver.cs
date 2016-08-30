using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class UnitPriceResolver : ValueResolver<LmFood, decimal?>
    {
        protected override decimal? ResolveCore(LmFood source)
        {
            decimal? unitPrice = null;

            if (source.BsItem != null)
            {
                unitPrice = source.BsItem.PriceIn;
            }

            return unitPrice;
        }
    }
}

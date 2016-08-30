using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class LocationFullNameResolver : ValueResolver<AdditionalMeal, string>
    {
        protected override string ResolveCore(AdditionalMeal source)
        {
            if (source != null)
            {
                InHosInfo hosInfo = source.InHosInfo;
                if (hosInfo != null)
                {
                    BsBed bedInfo = source.InHosInfo.BedInfo;
                    if (bedInfo != null)
                    {
                        return string.Concat(bedInfo.BsBedFloor.Name, bedInfo.RoomNo, "号房", bedInfo.Name, "床");
                    }
                }
            }

            return string.Empty;
        }
    }
}

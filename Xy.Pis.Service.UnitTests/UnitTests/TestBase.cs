using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests
{
    [TestClass]
    public class TestBase : Base
    {
        protected static readonly IAdditionalMealService additionalMealService = ServiceManager.GetService<IAdditionalMealService>();
        protected static readonly IDailyMenuService dailyMenuService = ServiceManager.GetService<IDailyMenuService>();

        protected AdditionalMealDTO PrepareData(int hospId, int locationId, DateTime orderDate, decimal unitPrice)
        {
            int userId = 999999;       

            AdditionalMealDTO additionalMealDto = new AdditionalMealDTO()
            {
                HospId = hospId,
                LocationId = locationId,
                OrderDate = orderDate,
                AddUser = userId,
                AddDate = orderDate,
                UpdtUser = userId,
                UpdtDate = orderDate
            };

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 26,
                Qty = 1,
                AdditionalMealType = "B",
                UnitPrice = unitPrice
            });
            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 27,
                Qty = 2,
                AdditionalMealType = "B",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 28,
                Qty = 1,
                AdditionalMealType = "L",
                UnitPrice = unitPrice
            });
            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 29,
                Qty = 1,
                AdditionalMealType = "L",
                UnitPrice = unitPrice
            });
            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 29,
                Qty = 2,
                AdditionalMealType = "D",
                UnitPrice = unitPrice
            });
            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 30,
                Qty = 1,
                AdditionalMealType = "D"
            });

            return additionalMealDto;
        }

    }
}

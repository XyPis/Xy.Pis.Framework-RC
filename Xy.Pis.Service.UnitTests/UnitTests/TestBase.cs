using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests
{
    [TestClass]
    public class TestBase : Base
    {       
        protected virtual AdditionalMealDTO PrepareData(int hospId, int locationId, DateTime orderDate, decimal unitPrice)
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
                FoodId = 10,
                Qty = 1,
                AdditionalMealType = "B",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 11,
                Qty = 2,
                AdditionalMealType = "B",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 12,
                Qty = 1,
                AdditionalMealType = "L",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 13,
                Qty = 1,
                AdditionalMealType = "L",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 15,
                Qty = 2,
                AdditionalMealType = "D",
                UnitPrice = unitPrice
            });

            additionalMealDto.Details.Add(new AdditionalMealDetailsDTO()
            {
                FoodId = 15,
                Qty = 1,
                AdditionalMealType = "D"
            });

            return additionalMealDto;
        }
    }
}

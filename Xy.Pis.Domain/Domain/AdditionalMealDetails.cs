using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class AdditionalMealDetails : EntityBase
    {
        public int Id { get; set; }
        
        public int AdditionalMealId { get; set; }

        public int FoodId { get; set; }
        
        public int Qty { get; set; }
        
        public decimal UnitPrice { get; set; }
        
        public string AdditionalMealType { get; set; }
        
        public virtual AdditionalMeal AdditionalMeal { get; set; }
        
        public virtual LmFood Food { get; set; }
    }
}

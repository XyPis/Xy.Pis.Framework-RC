using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsDrawStep
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> FunctionListId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> UserLevelId { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> IconIndex { get; set; }
    }
}

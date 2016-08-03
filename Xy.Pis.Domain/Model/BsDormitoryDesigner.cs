using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsDormitoryDesigner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> FloorNum { get; set; }
        public string TypeName { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public Nullable<int> SizeWidth { get; set; }
        public Nullable<int> SizeHeight { get; set; }
        public Nullable<bool> IsShowBorder { get; set; }
        public Nullable<int> ShowTitle { get; set; }
        public Nullable<int> BedCount { get; set; }
    }
}

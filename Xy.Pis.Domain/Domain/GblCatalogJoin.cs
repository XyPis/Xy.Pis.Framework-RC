using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblCatalogJoin
    {
        public int ID { get; set; }
        public int CatalogId1 { get; set; }
        public string XmlField1 { get; set; }
        public int CatalogId2 { get; set; }
        public string XmlField2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog1 { get; set; }
    }
}

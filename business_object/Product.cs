using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverEpamLab2.business_object
{
    class Product
    {
        public string inNameVal { get; set; }
        public string unitPriceVal ;
        public string inQuantityVal;
        public string inUnitInStockVal;
        public string inUnitsOnOrderVal;
        public string inReorderLevelVal;

        public Product(string inNameVal, string unitPriceVal, string inQuantityVal, string inUnitInStockVal, string inUnitsOnOrderVal, string inReorderLevelVal)
        {
            this.inNameVal = inNameVal;
            this.unitPriceVal = unitPriceVal;
            this.inQuantityVal = inQuantityVal;
            this.inUnitInStockVal = inUnitInStockVal;
            this.inUnitsOnOrderVal = inUnitsOnOrderVal;
            this.inReorderLevelVal = inReorderLevelVal;

        }

        public Product()
        {

        }
    }
}

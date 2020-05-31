using System;
using System.Collections.Generic;
using System.Text;

namespace TestSeleniumBasic.Business_object
{
    class Product
    {
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public string Supplier { get; set; }
        public string UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Pie { get; set; }
        public string ecpectedProductEditing { get; set; }

    public Product(string ProductName, string CategoryID, string Supplier, string UnitPrice,
            string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Pie, string ecpectedProductEditing)
        {
            
            this.ProductName = ProductName;
            this.CategoryID = CategoryID;
            this.Supplier = Supplier;
            this.UnitPrice = UnitPrice;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitsOnOrder = UnitsOnOrder;
            this.UnitsInStock = UnitsInStock;
            this.ReorderLevel = ReorderLevel;
            this.Pie = Pie;
            this.ecpectedProductEditing = ecpectedProductEditing;
        }
    }
}

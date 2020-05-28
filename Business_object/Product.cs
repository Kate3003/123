using System;
using System.Collections.Generic;
using System.Text;

namespace TestSeleniumBasic.Business_object
{
    class Product
    {
        public string SearchName { get; set; }
        public string SearchCategory { get; set; }
        public string SearchSupplier { get; set; }
        public string SearchUnitPrice { get; set; }
        public string SearchQuantityPerUnit { get; set; }
        public string SearchUnitsInStock { get; set; }
        public string SearchUnitsOnOrder { get; set; }
        public string SearchReorderLevel { get; set; }
        public string SearchPie { get; set; }

        public Product(string SearchName, string SearchCategory, string SearchSupplier, string SearchUnitPrice,
            string SearchQuantityPerUnit, string SearchUnitsInStock, string SearchUnitsOnOrder, string SearchReorderLevel, string SearchPie)
        {
            
            this.SearchName = SearchName;
            this.SearchCategory = SearchCategory;
            this.SearchSupplier = SearchSupplier;
            this.SearchUnitPrice = SearchUnitPrice;
            this.SearchQuantityPerUnit = SearchQuantityPerUnit;
            this.SearchUnitsOnOrder = SearchUnitsOnOrder;
            this.SearchUnitsInStock = SearchUnitsInStock;
            this.SearchReorderLevel = SearchReorderLevel;
            this.SearchPie = SearchPie;
        }

    }
}

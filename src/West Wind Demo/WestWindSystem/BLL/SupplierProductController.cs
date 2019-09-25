using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.DataModels;

namespace WestWindSystem.BLL
{
    class SupplierProductController
    {
        [DataObject] // this class provides access to objects that can be DataBound to UI controls
        public class ProductManagementController
        {
            #region Query Product Catalog
            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<ProductCategory> ListCurrentProducts()
            {
                using (var context = new WestWindContext())
                {
                    // Apply my LinqPad query to this method
                    var result = from company in context.Supplier
                                 select new ProductCategory
                                 {
                                     CompanyName = company.CompanyName,
                                     ContactName = company.ContactName,
                                     PhoneNumber = company.Phone,
                                     Product = from item in company.Products
                                               select new //
                                               {
                                                   name = item.ProductName,
                                                   price = item.UnitPrice,
                                                   Qty = item.QuantityPerUnit
                                               }
                                 };
                    return result.ToList();
                }
            }
        }
}

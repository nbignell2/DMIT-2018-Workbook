using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    [DataObject]
    public class CRUDController
    {
        #region Products CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Product> ListProducts()
        {
            using (var context = new WestWindContext())
            {
                return context.Products.ToList();
            }
        }
        #endregion

        #region Suppliers CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Supplier> ListSuppliers()
        {
            using(var context = new WestWindContext())
            {
                // .Include(string) will "eager load" the Address information
                // for the supplier.
                return context.Suppliers.Include(nameof(Supplier.Address)).ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void AddSupplier(Supplier item)
        {
            using(var context = new WestWindContext())
            {
                context.Suppliers.Add(item);
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateSupplier(Supplier item)
        {
<<<<<<< HEAD
            using (var context = new WestWindContext())
=======
            using(var context = new WestWindContext())
>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
            {
                var existing = context.Entry(item);
                existing.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
<<<<<<< HEAD
=======

>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
        public void DeleteSupplier(Supplier item)
        {
            using (var context = new WestWindContext())
            {
<<<<<<< HEAD
                var existing = context.Suppliers.Find(item.SupplierID);
=======
                var existing = context.Suppliers.Find
                    (item.SupplierID);
>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
                context.Suppliers.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion

        #region Categories CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Category> ListCategories()
        {
            using(var context = new WestWindContext())
            {
                return context.Categories.ToList();
            }
        }
        #endregion

        #region Addresses CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Address> ListAddresses()
        {
            using(var context = new WestWindContext())
            {
                return context.Addresses.ToList();
            }
        }
        #endregion
    }
}

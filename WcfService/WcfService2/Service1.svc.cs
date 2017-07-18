using System.Collections.Generic;
using System.Linq;

namespace WcfService2
{

    public class Service1 : IService1
    {
        private readonly SupplierContext _supplierContext;
        public Service1()
        {
            _supplierContext = new SupplierContext();
        }
        public IEnumerable<Supplier> GetSuppliers()
        {
            return _supplierContext.Suppliers.ToList();
        }

        public void DeleteSupplier(int id)
        {
            Supplier su = _supplierContext.Suppliers.Find(id);
            if (su != null)
            {
                _supplierContext.Suppliers.Remove(su);
                _supplierContext.SaveChanges();
            }
        }

        public Supplier GetSupplier(int id)
        {
            var su = _supplierContext.Suppliers.Find(id);
            return su;
        }

        public void InsertSupplier(Supplier sObj)
        {
            //sObj.SupplierId = 0;
            _supplierContext.Suppliers.Add(sObj);
            _supplierContext.SaveChanges();
        }

        public void UpdateSupplier(Supplier sObj)
        {
            Supplier su = _supplierContext.Suppliers.Find(sObj.SupplierId);
            if (su != null)
            {
                su.ContactNumber = sObj.ContactNumber;
                su.SupplierName = sObj.SupplierName;
                su.Notes = sObj.Notes;
            }
            _supplierContext.SaveChanges();
        }
    }

}

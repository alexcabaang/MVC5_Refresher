using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService2
{
    [ServiceContract]
    public interface IService1
    {    
        [OperationContract]
        IEnumerable<Supplier> GetSuppliers();
        [OperationContract]
        void InsertSupplier(Supplier sObj);
        [OperationContract]
        void UpdateSupplier(Supplier sObj);
        [OperationContract]
        Supplier GetSupplier(int id); 
        [OperationContract]
        void DeleteSupplier(int id);
    }

    [DataContract]
    public class Supplier
    {
        [DataMember]
        public int SupplierId { get; set; }
        [DataMember]
        public string SupplierName { get; set; }
        [DataMember]
        public string ContactNumber { get; set; }
        [DataMember]
        public string Notes { get; set; }
    }
}

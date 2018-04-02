using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DivService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [FaultContract(typeof(DivideFault))]
        [OperationContract(ProtectionLevel =ProtectionLevel.EncryptAndSign)]
        int div(int n1,int n2);
    }
}

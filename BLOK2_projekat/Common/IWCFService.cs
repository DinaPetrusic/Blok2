using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IWCFService
    {
        [OperationContract]
        [FaultContract(typeof(SecurityException))]
        string Read(string username, string fileName);

        [OperationContract]
        [FaultContract(typeof(SecurityException))]
        bool Generate(string username, string fileName, string msg);

        [OperationContract]
        [FaultContract(typeof(SecurityException))]
        bool Delete(string username, string fileName);
    }
}

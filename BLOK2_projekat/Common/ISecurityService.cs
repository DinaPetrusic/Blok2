using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ISecurityService
    {
        [OperationContract]
        void AddUser(string username, string password);

        [OperationContract]
        void RemoveUser(string username);

        [OperationContract]
        void AddUserGroup(string username, UserGroups group);

        [OperationContract]
        void RemoveUserGroup(string username, UserGroups group);

        [OperationContract]
        bool IsUserAuthenticated(string username);

        [OperationContract]
        bool IsUserAuthorized(string username, UserGroups group);
    }
}

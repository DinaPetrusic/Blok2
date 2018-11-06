using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
   public class ClientProxy : ChannelFactory<ISecurityService>, ISecurityService, IDisposable
    {
        ISecurityService factory;
        public ClientProxy(NetTcpBinding binding, string address) : base(binding, address)
        {
            factory = this.CreateChannel();
        }

        public void AddUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void AddUserGroup(string username, UserGroups group)
        {
            throw new NotImplementedException();
        }

        public bool IsUserAuthenticated(string username)
        {
            throw new NotImplementedException();
        }

        public bool IsUserAuthorized(string username, UserGroups group)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(string username)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserGroup(string username, UserGroups group)
        {
            throw new NotImplementedException();
        }
    }
}

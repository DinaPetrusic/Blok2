using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class WCFService : IWCFService, ISecurityService
    {
        public static Dictionary<string, Users> UserAccountsDB = new Dictionary<string, Users>();
        public void AddUser(string username, string password)
        {
            if (!UserAccountsDB.ContainsKey(username))
            {
                UserAccountsDB.Add(username, new Users(username, new NetworkCredential("", password).SecurePassword));
                Console.WriteLine("User added");
            }
        }

        public void AddUserGroup(string username, UserGroups group)
        {
            if (UserAccountsDB.ContainsKey(username))
            {
                if (UserAccountsDB[username].IsAuthenticated)
                {
                    UserAccountsDB[username].MemberOf.Add(group);
                }
            }
        }

        public bool Delete(string username, string fileName)
        {
            throw new NotImplementedException();
        }

        public bool Generate(string username, string fileName, string msg)
        {
            throw new NotImplementedException();
        }

        public bool IsUserAuthenticated(string username)
        {
            if (UserAccountsDB.ContainsKey(username))
            {
                return UserAccountsDB[username].IsAuthenticated;
            }
            return false;
        }

        public bool IsUserAuthorized(string username, UserGroups group)
        {

            if (UserAccountsDB.ContainsKey(username))
            {
                if (UserAccountsDB[username].HasRight(group))
                {
                    return true;
                }
            }
            return false;
        }

        public string Read(string username, string fileName)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(string username)
        {
            if (UserAccountsDB.ContainsKey(username))
            {
                UserAccountsDB.Remove(username);
                Console.WriteLine("User removed");
            }
        }

        public void RemoveUserGroup(string username, UserGroups group)
        {
            if (UserAccountsDB.ContainsKey(username))
            {
                UserAccountsDB[username].MemberOf.Remove(group);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum UserGroups { Reader, AlarmGenerator, AlarmAdmin };


    [DataContract]

    public class Users
    {
        string username = string.Empty;
        SecureString password;
        bool isAuthenticated = false;
        string computerName = string.Empty;
        List<UserGroups> memberOf;

        public Users(string _username, SecureString _password)
        {
            this.username = _username;
            this.password = _password;
            memberOf = new List<UserGroups>();
        }
        [DataMember]

        public List<UserGroups> MemberOf
        {
            get { return memberOf; }
            set { memberOf = value; }
        }


        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public SecureString Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
            set { isAuthenticated = value; }
        }
        [DataMember]
        public string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }

        public bool HasRight(UserGroups group)
        {
            return memberOf.Contains(group);

        }

    }
}

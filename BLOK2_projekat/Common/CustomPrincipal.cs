using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CustomPrincipal : IPrincipal
    {
        public IIdentity Identity { get; set; }

        public CustomPrincipal(WindowsIdentity iid)
        {
            Identity = iid;
        }

        public bool IsInRole(string role)
        {
            foreach (IdentityReference group in (Identity as WindowsIdentity).Groups)
            {
                SecurityIdentifier sid = (SecurityIdentifier)group.Translate(typeof(SecurityIdentifier));
                var name = sid.Translate(typeof(NTAccount));

                if (name.Equals(role))
                    return true;
            }

            return false;
        }
    }
}

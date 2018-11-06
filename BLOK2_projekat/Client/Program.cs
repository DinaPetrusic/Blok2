using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ResourceWriter resx = new ResourceWriter(@".\ResourceFile.resx"))
            {
                
                resx.AddResource("poruka", "value");
            }

            Console.ReadLine();
        }
    }
}

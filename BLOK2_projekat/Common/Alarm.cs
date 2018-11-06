using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Alarm
    {
       DateTime vrijeme;
       string ime;
       string poruka;
        int rizik;
       public int calculateRisk()
        {
            Random r = new Random();
            return r.Next(1, 1000000);
        }

        public Alarm(DateTime v, string i, string p, int r)
        {
            vrijeme = v;
            ime = i;
            poruka = p;
            rizik = r;
        }

        [DataMember]
        public DateTime Vrijeme
        {
            get { return vrijeme; }
            set { value = vrijeme; }
        }

        [DataMember]
        public string Ime
        {
            get { return ime; }
            set { value = ime; }
        }

        [DataMember]
        public string Poruka
        {
            get { return poruka; }
            set { value = poruka; }
        }
    }
}

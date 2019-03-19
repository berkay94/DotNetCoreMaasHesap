using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Models
{
    public class Maas
    {
        public int Agi { get; set; }
        public decimal PMaas { get; set; }

        public decimal GenelToplam
        {
            get
            {
                return PMaas + Agi;
            }
        }
    }
}

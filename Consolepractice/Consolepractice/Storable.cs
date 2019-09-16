using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolepractice
{
   public enum Status
    {
        ok,
        fail
    };
    interface Storable
    {
        void write(object obj);
        string Read();

       Status Returnstatus { get; set; }

    }
}

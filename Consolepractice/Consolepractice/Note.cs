using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolepractice
{
    public class Note : Storable
    {
        private Status Status;
        public Status Returnstatus
        {
            get
            {
                return Status;

            }
            set
            {
                Status = value;
            }
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void write(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

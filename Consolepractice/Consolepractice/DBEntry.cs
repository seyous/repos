using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolepractice
{
    class DBEntry : Storable
    {

        private Status status;
        public Status Returnstatus
        {
            get
            {
                return status;

            }
            set
            {
                status = value;
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

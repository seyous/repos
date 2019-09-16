using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Consolepractice
{
    public class Loancollection : IEnumerable
    {
        private readonly Loan[] _loancollection;

        public Loancollection(Loan[] loanArray)
        {
            _loancollection = new Loan[loanArray.Length];
            for (int i = 1; i <= loanArray.Length; i++)
            {

                _loancollection[i] = loanArray[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return _loancollection.GetEnumerator();
            Console.ReadKey();
        }
    }

    public class Name
    {
        public int[] Values { get; set; }
        public string Firstname;
        public string Lastname;

        public static Name ConvertToName(string Json)
        {
            var ser = new JavaScriptSerializer();
                return ser.Deserialize<Name>(Json);
        }
    }

}



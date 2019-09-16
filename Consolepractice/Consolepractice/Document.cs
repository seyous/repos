using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolepractice
{
    class Document
    {
        public string Text { get; set; }

        public delegate int SendDoc();

        public void FindingResult(SendDoc senddelegate)
        {
            if (senddelegate() == 0)
            {
                Console.WriteLine("sucess");
            }
            else
            {
                Console.WriteLine("failure");
            }
        }
    }
}

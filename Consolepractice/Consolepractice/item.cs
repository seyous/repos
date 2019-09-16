using System;
namespace Consolepractice
{
    public class item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual void Purchase()
        {
            Console.WriteLine("the name of purchase is:{0}", Name);
            
        }
        public static item GetItem()
        {
            var newitem = new item() { ID = 2, Name = "my sister" };
            return newitem;
        }
    }

    class software : item
    {
        public string ISDN { get; set; }
    }
    class hardware : item
    {
        public string serialNumber { get; set; }
    }

    class computer : hardware
    {
        public string CPUtype { get; set; }
        public string Disks { get; set; }

        public override void Purchase()
        {
            Console.WriteLine("the CPUtype is:{0}", CPUtype);
        }
    }
    class Peripheral : hardware
    {
        string description { get; set; }
    }
}
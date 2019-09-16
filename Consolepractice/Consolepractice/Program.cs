using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consolepractice
{
    //    class Employee
    //    {
    //        //private int age;
    //        // public int myAge(int someAge)
    //        //{
    //        //    age = someAge;
    //        //    return age;
    //        //}

    //        //public int Age {
    //        //    get {
    //        //        return age; }
    //        //        set { age = value; }
    //        //}

    //        //public void setAge(int someage)
    //        //{
    //        //    age = someage;
    //        //}

    //        public int Age { get; set; }
    //        public string Name { get; set; }
    //        public double Salary { get; set; }
    //        public DateTime Startingdate { get; set; }
    //        public string Phonenumber { get; set; }


    //    public void Newsalary(double bonus)
    //     {
    //            Salary += Salary * bonus;

    //    }
    //        public Employee(int age, string name, string phone, double salary, DateTime time)
    //        {
    //            Age = age;
    //            Name = name;
    //            Phonenumber = phone;
    //            Salary = salary;
    //            Startingdate = time;

    //        }
    //        public Employee()
    //        {

    //        }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Ghent", "London", "Las Vegas", "Hyderabad" };
            IEnumerable<string> query = cities.StringsThatStartWith("H");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


           
            //Document doc = new Document();
            //doc.Text = ("the document goes here");

            //var Emailsender = new Sendmail();
            //var blogdelegate = new Document.SendDoc(Emailsender.mailsender);
            //doc.FindingResult(blogdelegate);

            //DateTime date = new DateTime(2019, 6, 10);
            //int daysTillEndofMonth = dateutilities.daystoendofmonth(date);
            //Console.WriteLine(daysTillEndofMonth);
            //Console.ReadLine();
            //var mystorables = new List<Storable>();
            //Note mynote = new Note();
            //mystorables.Add(mynote);
            //DBEntry entry = new DBEntry();
            //mystorables.Add(entry);

            //Warehouse newWarehouse = new Warehouse(101, "Creek");
            // var myitem = newWarehouse.FindandReturn(101);
            //Console.WriteLine("the name of item is:{0}", myitem);
            //Console.ReadLine();
            //var mycomputer = new computer();
            //mycomputer.CPUtype = "Pentium 4";

            //item mysecondcomputer = new computer();
            //mysecondcomputer.ID = 2;

            //computer myseconcomputer2 = new computer() as computer;
            //myseconcomputer2.Name = "Pentium 2";
            //myseconcomputer2.CPUtype = "Aser";
            //string myCPUtype = myseconcomputer2.CPUtype;
            //myseconcomputer2.Purchase();
            //Console.ReadLine();

            //var realitem =item.GetItem();
            //Console.WriteLine("the new of {0} and {1}", realitem.ID, realitem.Name);
            //Console.ReadLine();

            //Console.Write("choose the age between 1 and 5:" );
            //string agestring = Console.ReadLine();
            //int age = int.Parse(agestring);

            //if(age > 65)
            //{
            //    Console.WriteLine("You are a senior citizen");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("You are a junior citizen");
            //    Console.ReadLine();
            //}

            //while (age > 0)
            //{
            //    Console.WriteLine("Happy Birthday");
            //    Console.ReadLine();

            //    age--;
            //}
            //switch (age)
            //{
            //    case 5:
            //        Console.WriteLine("you choose 5");
            //        break;
            //    case 6:
            //        Console.WriteLine("you choose 6");
            //        break;
            //    case 4:
            //        Console.WriteLine("you choose 4");
            //        break;
            //    case 3:
            //        Console.WriteLine("you choose 3");
            //        break;
            //    default:
            //        Console.WriteLine("you choose 2");
            //        break;

            //}

            //var items = new item2[5];
            //Random s = new Random();
            //for(int i=0; i<items.Length; i++)
            //{
            //    items[i] = new item2(s.Next());
            //}
            //Console.WriteLine("items:");
            //foreach(item2 item in items)
            //{
            //    Console.WriteLine("itemID is {0}", item.ID);

            //}
            //Console.ReadLine();

            //Array.Sort(items);
            //Employee employee = new Employee() { Age = 35, Name = "Daddy", Phonenumber = "07893333", Salary = 0.9739, Startingdate = new DateTime(12 / 07 / 2016) };
            ////employee.setAge(35);
            //// int y = employee.myAge(35);
            ////employee.Age = 35;
            //Console.WriteLine("the employee age is:{0} and name is: {1} He get a salary of {2}", employee.Age, employee.Name, employee.Salary);

            //employee.Newsalary(3.65);
            //Console.WriteLine("the employee age is:{0} and name is: {1} He get a salary of {2}", employee.Age,employee.Name,employee.Salary);
            //Console.ReadLine();

            //Employee mary = new Employee(35, "Mary Jones", "098756788", 9.087, new DateTime(08/08/2009));
        }

        //public static class dateutilities
        //{
        //    public static int daystoendofmonth(DateTime date)
        //    {
        //        return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        //    }
    }
        public static class FilterExtensions
        {
            public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> input, string start)
            {
                foreach (var s in input)
                {
                    if (s.StartsWith(start))
                    {
                        yield return s;
                    }
                }
            }

        }
    
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static string ValidateUser(Rational rat)
        {
            Type t = typeof(Rational);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (DeveloperInfoAttribute attr in attrs)
            {
                Console.WriteLine(attr.date);
                Console.WriteLine(attr.name);
            }
            return null;
        }
        static string ValidateUser2(Building build)
        {
            Type t = typeof(Building);
            object[] data = t.GetCustomAttributes(false);
            foreach (BuildingAttribute dat in data)
            {
                Console.WriteLine(dat.name);
                Console.WriteLine(dat.name_company);
            }
            return null;
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Task 1");
            Bank bank = new Bank(1233434,500,Type_account.current);
            bank.DumpToScreen();
            Console.WriteLine("Task 2");
            Rational rational = new Rational(1,2);
            ValidateUser(rational);
            Console.WriteLine("Task 3");
            Building build = new Building();
            ValidateUser2(build);
            build.number = 1;
            build.height = 5;
            build.floors = 5;
            build.apartments = 20;
            build.entrances = 25;
            Console.WriteLine("Кол-во этажей: "+build.floors);
            Console.WriteLine("Кол-во квартир: "+build.apartments);
            Console.WriteLine("Высота дома в метрах: "+build.height);
            Console.WriteLine("Кол-во подъездов: "+build.entrances);
            Console.WriteLine("Номер дома: "+build.number);
        }

       
    }
}

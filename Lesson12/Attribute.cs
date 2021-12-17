using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)]
    public class DeveloperInfoAttribute:System.Attribute
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public DeveloperInfoAttribute(string name, byte day, byte month, int year) 
        {
            this.name = name;
            date = new DateTime(year, month, day);
        }
    }
}

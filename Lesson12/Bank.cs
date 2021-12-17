#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public enum Type_account
    {
        saving = 1,
        current = 0
    }
    class Bank
    {

        private long Id { get; set; }
        private decimal balance { get; set; }
        private Type_account type { get; set; }
        public Bank(long id, decimal balance, Type_account type)
        {
            this.Id = id;
            this.type = type;
            this.balance = balance;
        }
        [System.Diagnostics.Conditional("DEBUG")]
        public void DumpToScreen() 
        {
            Console.WriteLine("Данные об аккаунте:id: "+Id+", balance: "+balance +",type: "+type ); 
        }
    }
}

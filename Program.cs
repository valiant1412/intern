using ConsoleApp1.OOP.ManageEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1.OOP.BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathname = "C:\\Users\\ASUS\\Desktop\\Learn C#\\ConsoleApp1\\ConsoleApp1\\OOP\\BankAccount\\Account.txt";
            Account account = new Account();
            bool create_account = account.CreateAccount();
            if (create_account)
            {
                using (StreamWriter writer = File.AppendText(pathname))
                {
                    Console.WriteLine("You have added a new account");
                    writer.WriteLine(account.Name + "," + account.Account_number);
                }
            }
        }
    }
}

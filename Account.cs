using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using System.Collections;
using System.Xml.Linq;

namespace ConsoleApp1.OOP.BankAccount
{
    class Account
    {
        private string name;
        private string account_number;
        private double balance;

        public Account(string name, string account_number, double balance)
        {
            this.name = name;
            this.account_number = account_number;
            this.balance = balance;
        }
        public Account() { }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Account_number
        {
            get { return this.account_number;}
            set { this.account_number = value;}
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public bool CreateAccount()
        {
            Console.WriteLine("Type your name");
            name = Console.ReadLine();
            string num;
            bool isTrue =true;
            string pathname = "C:\\Users\\ASUS\\Desktop\\Learn C#\\ConsoleApp1\\ConsoleApp1\\OOP\\BankAccount\\Account.txt";
            //validate the account number is exists or not
            while (true)
            {
                Console.WriteLine("Type your account number");
                account_number = Console.ReadLine();
                using (StreamReader reader = new StreamReader(pathname))
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        int count = 0;
                        string[] parts = line.Split(',');
                        string savedName = parts[0];
                        string savedNum = parts[1];
                        if (savedNum == account_number)
                        {

                            count++;
                            Console.WriteLine("Your account number is existed");
                            continue;
                        }
                        if (count <1)
                        {
                            return true;
                            break;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            
            
        }
    }
}

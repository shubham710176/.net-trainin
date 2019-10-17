using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{
    class Cust1
    {
        public int customer_id;
        public string customer_name;
        public int account_no;
        public double opening_balance;

        public  Cust1(int customer_id, string customer_name, int account_no, double opening_balance)
        {
            //    Console.WriteLine("enter id:");
            //    customer_id =int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter name :");
            //    customer_name = Console.ReadLine();
            //    Console.WriteLine("enter account no.");
            //    account_no = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter opening balance");
            //    opening_balance = double.Parse(Console.ReadLine());
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.account_no = account_no;
            this.opening_balance = opening_balance;
        }
        public void  Withdraw(double x)
        {
            opening_balance=(opening_balance - x);
            Console.WriteLine("current balance is:" + opening_balance);
        }
        public void  Deposit(double y)
        {
            opening_balance = (opening_balance + y);
            Console.WriteLine("current balance is:" + opening_balance);
        }
        //public void displaydet()
        //{
        //    Console.WriteLine("the id is:" + customer_id);
        //    Console.WriteLine("the name is:" + customer_name);
        //    Console.WriteLine("the account_no is:" + account_no);
        //    Console.WriteLine("the account balance is:" + opening_balance);
        //}
    }
}

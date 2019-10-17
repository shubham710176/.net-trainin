using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{
    class Program
    {
        static void Main(string[] args)

        {
            Cust1 c = new Cust1(121,"cus1",4563,34567);
            Cust1 c1 = new Cust1(247, "cus2", 4567, 33547);
            Cust1 c2 = new Cust1(318, "cus3", 4575, 34490);
            int choice;
            Console.WriteLine("enter customer no.");
            choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Customer details are:");
                    Console.WriteLine("id is"+c.customer_id);
                    Console.WriteLine("name is"+c.customer_name);
                    Console.WriteLine("account no."+c.account_no);
                    Console.WriteLine("opening balance."+c.opening_balance);
                    Withdra:
                    Console.WriteLine("Do you wish to withdraw amount");
                    Console.WriteLine("press y for continue and n to go to next option");
                    string ch;
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("enter withdraw amount");
                        double withdraw;
                        withdraw = double.Parse(Console.ReadLine());
                        if (withdraw < (c.opening_balance))
                        {
                            c.Withdraw(withdraw);
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal cant take place");
                        }
                    }
                    else
                    {
                        goto deposit;
                    }
                    deposit:
                    Console.WriteLine("Do you wish to deposit amount");

                    Console.WriteLine("press y for continue and n to go to next account");
                    string ch1;
                    ch1 = Console.ReadLine();
                    if (ch1 == "y")
                    {
                        Console.WriteLine("enter deposit amount");
                        double deposit;
                        deposit = double.Parse(Console.ReadLine());
                        c.Deposit(deposit);
                    }
                    else
                    {
                        Console.WriteLine("Do you wish to transact one more time");
                        Console.WriteLine("press y for continue and n to go to next account");
                        string ch2;
                        ch2 = Console.ReadLine();
                        if (ch2 == "y")
                        {
                            goto Withdra;
                        }
                 
                    }
                    break;
                case 2:
                    Console.WriteLine("Customer details are:");
                    Console.WriteLine("id is" + c1.customer_id);
                    Console.WriteLine("name is" + c1.customer_name);
                    Console.WriteLine("account no." + c1.account_no);
                    Console.WriteLine("opening balance." + c1.opening_balance);
                Withdrac1:
                    Console.WriteLine("Do you wish to withdraw amount");
                    Console.WriteLine("press y for continue and n to go to next option");
                    string chc1;
                    chc1 = Console.ReadLine();
                    if (chc1 == "y")
                    {
                        Console.WriteLine("enter withdraw amount");
                        double withdraw;
                        withdraw = double.Parse(Console.ReadLine());
                        if (withdraw < (c1.opening_balance))
                        {
                            c.Withdraw(withdraw);
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal cant take place");
                        }
                    }
                    else
                    {
                        goto depositc1;
                    }
                depositc1:
                    Console.WriteLine("Do you wish to deposit amount");

                    Console.WriteLine("press y for continue and n to go to next account");
                    string chc11;
                    chc11 = Console.ReadLine();
                    if (chc11 == "y")
                    {
                        Console.WriteLine("enter deposit amount");
                        double deposit;
                        deposit = double.Parse(Console.ReadLine());
                        c1.Deposit(deposit);
                    }
                    else
                    {
                        Console.WriteLine("Do you wish to transact one more time");
                        Console.WriteLine("press y for continue and n to go to next account");
                        string ch2;
                        ch2 = Console.ReadLine();
                        if (ch2 == "y")
                        {
                            goto Withdrac1;
                        }

                    }
                    break;
                case 3:
                    Console.WriteLine("Customer details are:");
                    Console.WriteLine("id is" + c2.customer_id);
                    Console.WriteLine("name is" + c2.customer_name);
                    Console.WriteLine("account no." + c2.account_no);
                    Console.WriteLine("opening balance." + c2.opening_balance);
                Withdrac2:
                    Console.WriteLine("Do you wish to withdraw amount");
                    Console.WriteLine("press y for continue and n to go to next option");
                    string chc2;
                    chc2 = Console.ReadLine();
                    if (chc2 == "y")
                    {
                        Console.WriteLine("enter withdraw amount");
                        double withdraw;
                        withdraw = double.Parse(Console.ReadLine());
                        if (withdraw < (c2.opening_balance))
                        {
                            c2.Withdraw(withdraw);
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal cant take place");
                        }
                    }
                    else
                    {
                        goto depositc2;
                    }
                depositc2:
                    Console.WriteLine("Do you wish to deposit amount");

                    Console.WriteLine("press y for continue and n to go to next account");
                    string chc21;
                    chc21 = Console.ReadLine();
                    if (chc21 == "y")
                    {
                        Console.WriteLine("enter deposit amount");
                        double deposit;
                        deposit = double.Parse(Console.ReadLine());
                        c1.Deposit(deposit);
                    }
                    else
                    {
                        Console.WriteLine("Do you wish to transact one more time");
                        Console.WriteLine("press y for continue and n to go to next account");
                        string ch2;
                        ch2 = Console.ReadLine();
                        if (ch2 == "y")
                        {
                            goto Withdrac2;
                        }

                    }
                    break;
            }

        }
    }
}

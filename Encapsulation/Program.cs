namespace Encapsulation
{
    //class Account
    //{
    //    int accountBalance = 1000;

    //    public void SetBalance(int amount)
    //    {
    //        if (amount<0)
    //        {
    //            Console.WriteLine("You can't pass negative value");
    //        }
    //        else
    //        {
    //            accountBalance = amount;
    //        }
    //    }
    //    public void GetBalance() 
    //    {
    //        Console.WriteLine("Your Account Balance is:"+accountBalance);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("Hello, World!");
    //        Account myAccount = new Account();
    //        myAccount.SetBalance(-10000);
    //        myAccount.GetBalance();
    //        Console.ReadLine();
    //    }
    //}

    //C# Properties (Same above Code through C# Properties)

    class Account
    {
        int accountBalance = 1000;
        public int Balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("YOu can't pass negative value");
                }
                else
                {
                    accountBalance = value;
                }
            }
            get 
            { 
                return accountBalance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Balance = -10000;
            Console.WriteLine("Your account balance is:" +myAccount.Balance);
            Console.ReadLine();
        }
    }


}
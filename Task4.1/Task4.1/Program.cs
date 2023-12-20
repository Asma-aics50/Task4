using System;

namespace Task4._1;

public enum Menuoption
{
    Withdraw =0,
    Deposit=1,
    Print=2,
    Quit=3

}


class Program
{
    
    public static Menuoption ReadUseroption()
    {
        int num = '\0';

        do {
            Console.WriteLine("choise from my list ");
            Console.WriteLine("0 - Withdraw");
            Console.WriteLine("1 - Deposite");
            Console.WriteLine("2 - Print");
            Console.WriteLine("3 - Quit");

            Console.WriteLine("enter your choise number :");
            num = Convert.ToInt32(Console.ReadLine());


        } while (num < 0 && num > 3 );
      return (Menuoption)num;
       
    }
    private static void Dowithdraw(Account account1)
    {
        Decimal num = '\0';
        Console.WriteLine("Enter the Withdraw amount :");
        num = Convert.ToDecimal(Console.ReadLine());

        account1.Withdraw(num);

    }
    private static void DoDeposit(Account account1)
    {
        Decimal num = '\0';
        Console.WriteLine("Enter the deposit amount :");
        num = Convert.ToDecimal(Console.ReadLine());

        account1.Deposit(num);


    }
    public static void DoPrint(Account account1)
    {

        account1.Print();

    }




    static void Main(string[] args)
    {
        Account account = new Account("Jakes", 200000);
        account.Print();
        //account.Deposit(100);
        //account.Print();
        //account.Withdraw(200);
        //account.Print();

        Account account1 = new Account("Asmaa",1000);
        //account1.Deposit(1000);
        account1.Print();
        //account.Withdraw(500);
        //account1.Print();
        do {

            Menuoption selectedOption = ReadUseroption();

            switch (selectedOption)
            {
                case Menuoption.Withdraw:
                    Dowithdraw(account1);
                    break;
                case Menuoption.Deposit:
                    DoDeposit(account1);
                    break;
                case Menuoption.Print:
                    DoPrint(account1);
                    break;
                case Menuoption.Quit:
                    Console.WriteLine($"{Menuoption.Quit}");
                    break;
                default:
                    Console.WriteLine("invalid option");

                    break;

            }


        } while (true);
        

    }
    
}



using System;
using System.Threading.Tasks.Dataflow;

public static class BankBal{
    public static void Main(){
        double BankBal = 1000;
        const double INT_RATE = 0.04;
        char response;

        Console.WriteLine("Do you want to see your balance? Y or N:");
        response = Convert.ToChar(Console.ReadLine());

        while(response == 'Y'){
            Console.WriteLine("your balance is {0:C}", BankBal);
            BankBal = BankBal + BankBal * INT_RATE;

            Console.WriteLine("Do you want to see next years balance? Y or N:");
             response = Convert.ToChar(Console.ReadLine());
        }
          Console.WriteLine("HAVE A NICE DAY");
          Console.ReadLine();

    }
}
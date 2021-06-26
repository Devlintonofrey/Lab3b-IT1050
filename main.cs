using System;
class MainClass {
  public static void Main (string[] args) {


double salecommission, saleamount;
    Console.WriteLine("Enter Salesperson's name");
    Console.ReadLine();

    Console.WriteLine("Enter the sale amount : ");
    saleamount = Convert.ToInt32(Console.ReadLine());

   salecommission = (saleamount * 0.09) + 200;


//Comparison >, <, ==, <=, >=
    if (salecommission < 2999 )
    {
      Console.WriteLine("Poor");
    }
    if (salecommission == 2999 )
    {
      Console.WriteLine("Poor");
    }

    if (salecommission == 3000 )
    {
      Console.WriteLine("Average");
    }
    if (salecommission > 3000 )
    {
      Console.WriteLine("Average");
    }
    if (salecommission < 4999 )
    {
      Console.WriteLine("Average");
    }
    if (salecommission == 4999 )
    {
      Console.WriteLine("Average");
    }

    if (salecommission == 5000 )
    {
      Console.WriteLine("Good");
    }
    if (salecommission < 9999 )
    {
      Console.WriteLine("Good");
    }

    if (salecommission == 9999 )
    {
      Console.WriteLine("Good");
    }

    if (salecommission > 5000 )
    {
      Console.WriteLine("Good");
    }

    if (salecommission == 10000 )
    {
      Console.WriteLine("Excellent");
    }
if (salecommission > 10000 )
    {
      Console.WriteLine("Excellent");
    }
if (salecommission < 14999 )
    {
      Console.WriteLine("Excellent");
    }

if (salecommission == 14999 )
    {
      Console.WriteLine("Excellent");
    }

    if (salecommission > 15000 )
    {
      Console.WriteLine("Outstanding");
    }
    



  }
}

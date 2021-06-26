using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine("Enter the salesperson's name");
   string salesperson = Console.ReadLine();
   Console.WriteLine("Enter sales amount");
   double salesAmount = Convert.ToDouble(Console.ReadLine());

   double salesCommission = 200 + (0.09 * salesAmount);Console.WriteLine("Sales commission for " + salesperson + " is $" + salesCommission);

   if (salesAmount > 0 && salesAmount < 2999) {
     Console.WriteLine("Performance is Poor");
   }else if (salesAmount > 3000 && salesAmount < 4999) {
     Console.WriteLine("Performance is Average");
   }else if (salesAmount > 5000 && salesAmount < 9999) {
     Console.WriteLine("Performance is Good");
   }else if (salesAmount > 10000 && salesAmount < 14999) {
     Console.WriteLine("Performance is Excellent");
   }else if (salesAmount > 15000) {
     Console.WriteLine("Performance is Outstanding");
   }
  }
}
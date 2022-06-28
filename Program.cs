using System;

namespace CabInvoiceGenerator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t********WELCOME TO CAB INVOICE GENERATOR PROGRAM********");

            InvoiceGenerator objInvoiceGenerator = new InvoiceGenerator(RidesType.PREMIUM);
            double Fare = objInvoiceGenerator.Calculate_Fare(2.0, 5);
            Console.WriteLine("Total Fare : {0}", Fare);
            Console.ReadKey();
        }
    }
}
using System;

class TicketPriceCalculator
{
static void Main()
{
    const int regularPrice = 10;
    const int discountedPrice = 7;

    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine());

    int ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : regularPrice;
    Console.Write($"The ticket price is GHC{ticketPrice}");

}




}

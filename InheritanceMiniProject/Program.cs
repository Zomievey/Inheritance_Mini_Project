using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();
            List<IPurchase> purchases = new List<IPurchase>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima", QuantityInStock = 1 };
            var book = new BookModel { NumberOfPages = 350, ProductName = "C# for Dummies", QuantityInStock = 5 };
            var excavator = new ExcavatorModel { ProductName = "John Deere 350G", QuantityInStock = 4 };

            rentals.Add(vehicle);
            rentals.Add(excavator);

            purchases.Add(vehicle);
            purchases.Add(book);


            Console.Write("Do you wan to rent or purchase an item? (Rent/Purchase): ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentals)  // loops through every item that is available to rent
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item? (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if
                        (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                        Console.WriteLine($"You have rented {item.ProductName}");
                        Console.WriteLine($"There are {item.QuantityInStock} left in stock.");
                    }
                    else
                    {
                        Console.WriteLine("No problem. Have a great day!");
                    }

                    Console.Write("Do you want to return this item? (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if
                        (wantToRent.ToLower() == "yes")
                    {
                        item.ReturnRental();
                        Console.WriteLine($"You have returned {item.ProductName}");
                        Console.WriteLine($"There are {item.QuantityInStock} left in stock.");
                    }
                    else
                    {
                        Console.WriteLine("No problem. Have a great day!");
                    }
                }
            }
            else
            {
                foreach (var item in purchases)  // loops through every item that is available to purchase
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item? (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if
                        (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                        Console.WriteLine($"You have purchased {item.ProductName}");
                        Console.WriteLine($"There are {item.QuantityInStock} left in stock.");
                    }
                    else
                    {
                        Console.WriteLine("No problem. Have a great day!");
                    }
                }
            }

            Console.WriteLine("Thank you for using the Inventory Program.");
            Console.ReadLine();
        }
    }
}

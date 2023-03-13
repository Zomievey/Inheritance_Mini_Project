using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel, IRental  // can only be rented
    {
        public void Dig()
        {
            Console.WriteLine("Digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The Excavator has been returned");
        }
    }
}

using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel, IPurchase // can on only purchase books
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased.");
        }
    }
}

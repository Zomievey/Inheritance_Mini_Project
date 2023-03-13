namespace InheritanceMiniProject
{
    public interface IRental : IInventoryItem
    {
        void Rent(); // subtract one from inventory

        void ReturnRental(); // add one to inventory


    }
}

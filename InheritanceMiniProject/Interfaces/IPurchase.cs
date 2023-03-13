namespace InheritanceMiniProject
{
    public interface IPurchase : IInventoryItem
    {
        void Purchase(); // subtract one from inventory

    }
}

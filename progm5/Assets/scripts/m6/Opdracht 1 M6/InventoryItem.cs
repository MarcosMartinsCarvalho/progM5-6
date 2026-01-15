public abstract class InventoryItem
{
    public string ItemName { get; protected set; }

    protected InventoryItem(string itemName)
    {
        ItemName = itemName;
    }
}

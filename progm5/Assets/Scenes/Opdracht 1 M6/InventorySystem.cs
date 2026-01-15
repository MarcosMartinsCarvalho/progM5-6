using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private List<InventoryItem> _inventoryItems = new List<InventoryItem>();

    [SerializeField] private int _worldGuns = 2;
    [SerializeField] private int _worldMedipacks = 4;
    [SerializeField] private int _worldKeycards = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            AddItem(new GunItem(), ref _worldGuns);

        if (Input.GetKeyDown(KeyCode.M))
            AddItem(new MedipackItem(), ref _worldMedipacks);

        if (Input.GetKeyDown(KeyCode.K))
            AddItem(new KeycardItem(), ref _worldKeycards);
    }

    private void AddItem(InventoryItem item, ref int worldCount)
    {
        if (worldCount <= 0) return;

        _inventoryItems.Add(item);
        worldCount--;
        PrintInventory();
    }

    private void PrintInventory()
    {
        int guns = 0, medipacks = 0, keycards = 0;

        foreach (InventoryItem item in _inventoryItems)
        {
            if (item is GunItem) guns++;
            if (item is MedipackItem) medipacks++;
            if (item is KeycardItem) keycards++;
        }

        Debug.Log($"World -> Guns: {_worldGuns}, Medipacks: {_worldMedipacks}, Keycards: {_worldKeycards}");
        Debug.Log($"Inventory -> Guns: {guns}, Medipacks: {medipacks}, Keycards: {keycards}");
    }
}

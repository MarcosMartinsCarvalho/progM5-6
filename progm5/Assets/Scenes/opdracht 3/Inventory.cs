using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    public ItemTemplate[] itemTemplates;
    public ItemType filterType;

    void Start()
    {
        RefreshInventory();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RefreshInventory();
        }
    }

    void RefreshInventory()
    {
        items.Clear();

        foreach (ItemTemplate template in itemTemplates)
        {
            if (template.itemType == filterType)
            {
                Item newItem = template.CreateInstance();
                items.Add(newItem);
                Debug.Log(newItem.Describe());
            }
        }
    }
}

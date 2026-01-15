using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    private List<Collectable> collectibles = new List<Collectable>();

    void Start()
    {
        Collectable[] found = FindObjectsOfType<Collectable>();
        collectibles.AddRange(found);
        Debug.Log("Total collectibles: " + collectibles.Count);
    }

    public void Collect(Collectable collectable)
    {
        collectibles.Remove(collectable);
        Debug.Log("Collectible collected! Remaining: " + collectibles.Count);
    }
}

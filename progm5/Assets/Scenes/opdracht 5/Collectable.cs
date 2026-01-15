using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    protected CollectibleManager manager;

    protected virtual void Start()
    {
        manager = FindObjectOfType<CollectibleManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect();
            manager.Collect(this);
            Destroy(gameObject);
        }
    }

    public abstract void OnCollect();
}

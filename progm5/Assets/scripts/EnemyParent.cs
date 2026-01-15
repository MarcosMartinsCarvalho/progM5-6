using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int health = 3;

    protected Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}

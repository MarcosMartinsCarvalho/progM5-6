using UnityEngine;

public class Zombie2 : Enemy2
{
    void Start()
    {
        gameObject.name = "Zombie";
    }

    public override void TakeDamage(float damage)
    {
        float reduced = damage * 0.8f;
        health -= reduced;
        Debug.Log($"Zombie krijgt {reduced} damage! HP: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Zombie bijt {target.name}!");
    }
}

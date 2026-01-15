using UnityEngine;

public class Goblin2 : Enemy2
{
    private float evasionChance = 0.2f;

    void Start()
    {
        gameObject.name = "Goblin";
    }

    public override void TakeDamage(float damage)
    {
        if (Random.value < evasionChance)
        {
            Debug.Log("Goblin ontwijkt de aanval!");
            return;
        }

        base.TakeDamage(damage);
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Goblin schiet pijlen af op {target.name}!");
    }
}

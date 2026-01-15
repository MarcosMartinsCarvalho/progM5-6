using UnityEngine;

public class Troll2 : Enemy2
{
    void Start()
    {
        gameObject.name = "Troll";
        health = 200f;
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage * 0.7f);
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log("Troll slaat keihard met zijn knuppel!");
    }
}

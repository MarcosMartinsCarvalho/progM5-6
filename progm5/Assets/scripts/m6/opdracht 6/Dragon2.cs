using UnityEngine;

public class Dragon2 : Enemy2
{
    void Start()
    {
        gameObject.name = "Dragon";
        health = 1000f;
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Dragon spuwt vuur en verkoolt {target.name}!");
    }
}

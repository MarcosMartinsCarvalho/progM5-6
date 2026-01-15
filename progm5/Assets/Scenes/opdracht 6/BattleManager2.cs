using System.Collections.Generic;
using UnityEngine;

public class BattleManager2 : MonoBehaviour
{
    private List<Enemy2> enemies;

    void Start()
    {
        enemies = new List<Enemy2>
        {
            new GameObject().AddComponent<Zombie2>(),
            new GameObject().AddComponent<Goblin2>(),
            new GameObject().AddComponent<Dragon2>(),
            new GameObject().AddComponent<Troll2>()
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PRESSED - SPACE");
            foreach (Enemy2 enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.Attack(gameObject);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("PRESSED - D");
            foreach (Enemy2 enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.TakeDamage(25f);
                }
            }
        }
    }
}

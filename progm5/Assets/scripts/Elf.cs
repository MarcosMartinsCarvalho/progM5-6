using UnityEngine;
using System.Collections;

public class Elf : EnemyParent
{
    void Start()
    {
        moveSpeed = 8f;
        health = 2;
        rend = GetComponent<Renderer>();
        StartCoroutine(ToggleVisibilityRoutine());
    }

    IEnumerator ToggleVisibilityRoutine()
    {
        while (true)
        {
            rend.enabled = false;
            yield return new WaitForSeconds(0.5f);
            rend.enabled = true;
            yield return new WaitForSeconds(3f);
        }
    }
}

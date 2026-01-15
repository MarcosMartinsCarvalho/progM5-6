using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    public int scoreValue = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreSystem scoreSystem = FindObjectOfType<ScoreSystem>();
            scoreSystem.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}

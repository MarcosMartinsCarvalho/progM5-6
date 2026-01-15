using System;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;

    public Action<int> onScoreChanged;

    public void AddScore(int amount)
    {
        score += amount;
        onScoreChanged?.Invoke(score);
    }
}

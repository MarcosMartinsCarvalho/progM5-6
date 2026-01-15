using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private ScoreSystem scoreSystem;

    void Start()
    {
        scoreSystem = FindObjectOfType<ScoreSystem>();
        scoreSystem.onScoreChanged += UpdateScore;
        UpdateScore(scoreSystem.score);
    }

    void UpdateScore(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }

    void OnDestroy()
    {
        if (scoreSystem != null)
        {
            scoreSystem.onScoreChanged -= UpdateScore;
        }
    }
}

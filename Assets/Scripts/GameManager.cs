using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    public TextMeshProUGUI Score;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        score += amount;

        Debug.Log("Current Score: " + score);

        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (Score != null)
        {
            Score.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("Score NOT assigned!");
        }
    }
}
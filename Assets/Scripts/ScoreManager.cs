using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    public void AddScore(int additionalScore)
    {
        score += additionalScore;
        scoreText.text = "Score: " + score;
    }

        void Start()
    {
        AddScore(100);
    }
}

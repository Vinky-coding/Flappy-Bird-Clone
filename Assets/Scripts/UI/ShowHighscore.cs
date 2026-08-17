using UnityEngine;
using TMPro;
public class ShowHighscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowHighScore();
    }

    private void ShowHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Highest score: " + highScore.ToString();
    }
}

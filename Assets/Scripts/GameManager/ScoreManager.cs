using System;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; private set;}
    public int currentScore {get; private set;} = 0;
    public int highScore {get; private set;} 
    private const string HighScoreKey = "HighScore";
    [SerializeField] private TextMeshProUGUI scoreText;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
    }
    void Start()
    {
        scoreText.text = currentScore.ToString();
        
    }

    public void AddPoint()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }

    public void SaveHighScore()
    {
        if(currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt(HighScoreKey, highScore);
            PlayerPrefs.Save();
        } 
        else return;
    }
    
}
using System;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; private set;}
    public int currentScore {get; private set;} = 0;
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
}
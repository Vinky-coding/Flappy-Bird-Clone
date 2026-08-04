using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    [SerializeField] private GameObject gameOverScreen;
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
        GameObject gos = GameObject.Find("GameOver");
        if(gos != null)
        {
            gameOverScreen = GetComponent<GameObject>();
        }
    }
    public void GameOverScreen() 
    {
        gameOverScreen.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}

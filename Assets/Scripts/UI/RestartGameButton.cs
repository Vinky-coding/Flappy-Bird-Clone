using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartGameButton : MonoBehaviour
{
    private Scene scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    
}

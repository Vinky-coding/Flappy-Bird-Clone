using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        TouchScreenPlay();
    }

    private static void TouchScreenPlay()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            SceneManage.instance.LoadScene(1);
        }
    }


    
}

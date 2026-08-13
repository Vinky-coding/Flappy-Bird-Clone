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


    // hàm này được gọi khi người chơi nhấn nút "Exit" trong màn hình Game Over
    public void OnButtonClick()
    {
        SceneManage.instance.LoadScene(0);
    }
}

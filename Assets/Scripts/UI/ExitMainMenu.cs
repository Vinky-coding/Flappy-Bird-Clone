using UnityEngine;

public class ExitMainMenu : MonoBehaviour
{
    // hàm này được gọi khi người chơi nhấn nút "Exit" trong màn hình Game Over
    public void OnButtonClick()
    {
        Time.timeScale = 1f; // reset time scale to normal
        SceneManage.instance.LoadScene(0);
    }
}

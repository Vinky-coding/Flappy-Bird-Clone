using UnityEngine;

public class HitCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pipe"))
        {
            Destroy(gameObject);
            AudioManager.PlaySound(AudioManager.SoundType.GetHit);
            ScoreManager.Instance.SaveHighScore();
            GameManager.Instance.GameOverScreen();
            Time.timeScale = 0f;
        }     
    }
}

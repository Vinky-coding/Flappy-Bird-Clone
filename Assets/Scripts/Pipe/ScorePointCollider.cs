using UnityEngine;

public class ScorePointCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoint();
            AudioManager.PlaySound(AudioManager.SoundType.GetPoint);
        }
    }
}

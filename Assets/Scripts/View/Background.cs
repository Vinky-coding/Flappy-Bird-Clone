using UnityEngine;

public class Background : MonoBehaviour
{
    private float scrollingSpeed = 0.1f;
    [SerializeField] private Renderer bgRenderer;

    // Update is called once per frame
    void Update()
    {
        float offset = scrollingSpeed * Time.deltaTime;
        bgRenderer.material.mainTextureOffset += new Vector2(offset,0);
    }
}

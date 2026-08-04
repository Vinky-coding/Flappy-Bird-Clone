using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    private Vector3 fallAngle = new Vector3(0,0,-60);
    private Vector3 flapAngle = new Vector3(0,0,40);
    private Quaternion flapRotate,fallRotate;
    [SerializeField] private float jumpForce = 4f;
    private float rotateSpeed = 1f;
    // [SerializeField] private InputActionReference touch;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        fallRotate = Quaternion.Euler(fallAngle);
        flapRotate = Quaternion.Euler(flapAngle);
    }
    void Update()
    { 
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
           Jump();
           AudioManager.PlaySound(AudioManager.SoundType.Jump);
        }
        RotateFalling();
        
    }
    private void RotateFalling()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,fallRotate,rotateSpeed*Time.deltaTime);    
    }
    private void Jump()
    {
        rbPlayer.linearVelocity = new Vector2(rbPlayer.linearVelocityX,jumpForce);
        transform.rotation = flapRotate;  
    }
}

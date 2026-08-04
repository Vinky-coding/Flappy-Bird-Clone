using Unity.VisualScripting;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float towardSpeed {get; private set;} = 2f;
    private float disableX = -5f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * towardSpeed * Time.deltaTime;
        DestroyObject();
    }
    private void DestroyObject()
    {
        if(transform.position.x < disableX)
        {
            //Debug.Log("Destroy Object!");
            gameObject.SetActive(false);
        }
    }
}

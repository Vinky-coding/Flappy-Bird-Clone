using System.Collections;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [Header("Random Boundaries")]
    public float bottomBound,topBound;
    void Start()
    {
        StartCoroutine(SpawnInterval());
    }
    public void PipeSpawn()
    {
        float randomY = Random.Range(bottomBound,topBound);
        Vector2 randPos = new Vector2(pipePrefab.transform.position.x, randomY);
        transform.position = randPos;
        GameObject pipe = PoolManager.Instance.GetPool();
        if(pipe != null)
        {
            pipe.transform.position = transform.position;
            pipe.transform.rotation = transform.rotation;
            pipe.SetActive(true);
        }
        else
        {
            return;
        }
    }
    IEnumerator SpawnInterval()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.5f);
            PipeSpawn();
        }   
    }

}

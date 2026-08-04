using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance {get; private set;}
    private List<GameObject> poolList = new List<GameObject>();
    [SerializeField] private GameObject objectToPool;
    [SerializeField] private int poolAmount;
    void Awake()
    {
        // Tạo singeton cho PoolManager
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

        //Spawn Pool
        GameObject tmp;
        for(int i = 0; i < poolAmount; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            poolList.Add(tmp);
        }
    }
    public GameObject GetPool()
    {
        for(int i = 0; i < poolAmount; i++)
        {
            if(poolList[i].activeInHierarchy == false)
            {
                return poolList[i];
            }
        }
        return null;
    } 
}

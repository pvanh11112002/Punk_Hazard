using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoolManager : Singleton<ObjPoolManager>
{
    private List<GameObject> bulletpooledObjects = new List<GameObject>();
    public int bulletNumber;
    public GameObject bulletPrefab;

    private List<GameObject> explosionPooledObj = new List<GameObject>();
    public int explosionNumber;
    public GameObject explosionPrefab;
    
    void Start()
    {
        for (int i = 0; i < bulletNumber; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            bulletpooledObjects.Add(obj);
        }
        for (int j = 0; j < explosionNumber; j++)
        {
            GameObject obj = Instantiate(explosionPrefab);
            obj.SetActive(false);
            explosionPooledObj.Add(obj);
        }
    }
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < bulletpooledObjects.Count; i++)
        {
            if (!bulletpooledObjects[i].activeInHierarchy)
            {
                return bulletpooledObjects[i];
            }
        }
        return null;
    }
    public GameObject GetExplosionPooledObject()
    {
        for (int i = 0; i < explosionPooledObj.Count; i++)
        {
            if (!explosionPooledObj[i].activeInHierarchy)
            {
                return explosionPooledObj[i];
            }
        }
        return null;
    }
}

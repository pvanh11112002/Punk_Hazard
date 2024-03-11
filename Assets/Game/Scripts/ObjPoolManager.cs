using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoolManager : Singleton<ObjPoolManager>
{
    private List<GameObject> bulletPooledObjects = new List<GameObject>();
    public int bulletNumber;
    public GameObject bulletPrefab;

    private List<GameObject> explosionPooledObj = new List<GameObject>();
    public int explosionNumber;
    public GameObject explosionPrefab;

    private List<GameObject> monsterBulletPooledObjects = new List<GameObject>();
    public int monsterBulletNumber;
    public GameObject monsterBulletPrefab;

    private List<GameObject> meteoritePooledObjects = new List<GameObject>();
    public int meteoriteNumber;
    public GameObject meteoritePrefab;
    void Start()
    {
        //for (int i = 0; i < bulletNumber; i++)
        //{
        //    GameObject obj = Instantiate(bulletPrefab);
        //    obj.SetActive(false);
        //    bulletPooledObjects.Add(obj);
        //}
        //for (int j = 0; j < explosionNumber; j++)
        //{
        //    GameObject obj = Instantiate(explosionPrefab);
        //    obj.SetActive(false);
        //    explosionPooledObj.Add(obj);
        //}
        //for (int k = 0; k < monsterBulletNumber; k++)
        //{
        //    GameObject obj = Instantiate(monsterBulletPrefab);
        //    obj.SetActive(false);
        //    monsterBulletPooledObjects.Add(obj);
        //}
        //for (int l = 0; l < meteoriteNumber; l++)
        //{
        //    GameObject obj = Instantiate(meteoritePrefab);
        //    obj.SetActive(false);
        //    meteoritePooledObjects.Add(obj);
        //}

        if (GameManager.Instance.gameState == GameState.GamePlay)
        {
            for (int i = 0; i < bulletNumber; i++)
            {
                GameObject obj = Instantiate(bulletPrefab);
                obj.SetActive(false);
                bulletPooledObjects.Add(obj);
            }
            for (int j = 0; j < explosionNumber; j++)
            {
                GameObject obj = Instantiate(explosionPrefab);
                obj.SetActive(false);
                explosionPooledObj.Add(obj);
            }
            for (int k = 0; k < monsterBulletNumber; k++)
            {
                GameObject obj = Instantiate(monsterBulletPrefab);
                obj.SetActive(false);
                monsterBulletPooledObjects.Add(obj);
            }
            for (int l = 0; l < meteoriteNumber; l++)
            {
                GameObject obj = Instantiate(meteoritePrefab);
                obj.SetActive(false);
                meteoritePooledObjects.Add(obj);
            }
        }
    }
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < bulletPooledObjects.Count; i++)
        {
            if (!bulletPooledObjects[i].activeInHierarchy)
            {
                return bulletPooledObjects[i];
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
    public GameObject GetMonsterBulletPooledObject()
    {
        for (int i = 0; i < monsterBulletPooledObjects.Count; i++)
        {
            if (!monsterBulletPooledObjects[i].activeInHierarchy)
            {
                return monsterBulletPooledObjects[i];
            }
        }
        return null;
    }
    public GameObject GetMeteoritePooledObject()
    {
        for (int i = 0; i < meteoritePooledObjects.Count; i++)
        {
            if (!meteoritePooledObjects[i].activeInHierarchy)
            {
                return meteoritePooledObjects[i];
            }
        }
        return null;
    }
}

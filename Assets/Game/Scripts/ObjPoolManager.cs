using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoolManager : Singleton<ObjPoolManager>
{
    // Create Bullet
    private List<GameObject> bulletPooledObjects = new List<GameObject>();
    public int bulletNumber;
    public GameObject bulletPrefab;

    // Create Explosion
    private List<GameObject> explosionPooledObj = new List<GameObject>();
    public int explosionNumber;
    public GameObject explosionPrefab;

    // Create Bullet 4 Monster
    private List<GameObject> monsterBulletPooledObjects = new List<GameObject>();
    public int monsterBulletNumber;
    public GameObject monsterBulletPrefab;

    // Create Metorite
    private List<GameObject> meteoritePooledObjects = new List<GameObject>();
    public int meteoriteNumber;
    public GameObject meteoritePrefab;

    // Create Monster 1
    private List<GameObject> monster1PooledObjects = new List<GameObject>();
    public int monster1Number;
    public GameObject monster1Prefab;

    // Create Monster 2
    private List<GameObject> monster2PooledObjects = new List<GameObject>();
    public int monster2Number;
    public GameObject monster2Prefab;

    // Create Monster 3
    private List<GameObject> monster3PooledObjects = new List<GameObject>();
    public int monster3Number;
    public GameObject monster3Prefab;
    void Start()
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
        for (int a = 0; a < monster1Number; a++)
        {
            GameObject obj = Instantiate(monster1Prefab);
            obj.SetActive(false);
            monster1PooledObjects.Add(obj);
        }
        for (int b = 0; b < monster2Number; b++)
        {
            GameObject obj = Instantiate(monster2Prefab);
            obj.SetActive(false);
            monster2PooledObjects.Add(obj);
        }
        for (int c = 0; c < monster3Number; c++)
        {
            GameObject obj = Instantiate(monster3Prefab);
            obj.SetActive(false);
            monster3PooledObjects.Add(obj);
        }

        //if (GameManager.Instance.gameState == GameState.GamePlay)
        //{
        //    for (int i = 0; i < bulletNumber; i++)
        //    {
        //        GameObject obj = Instantiate(bulletPrefab);
        //        obj.SetActive(false);
        //        bulletPooledObjects.Add(obj);
        //    }
        //    for (int j = 0; j < explosionNumber; j++)
        //    {
        //        GameObject obj = Instantiate(explosionPrefab);
        //        obj.SetActive(false);
        //        explosionPooledObj.Add(obj);
        //    }
        //    for (int k = 0; k < monsterBulletNumber; k++)
        //    {
        //        GameObject obj = Instantiate(monsterBulletPrefab);
        //        obj.SetActive(false);
        //        monsterBulletPooledObjects.Add(obj);
        //    }
        //    for (int l = 0; l < meteoriteNumber; l++)
        //    {
        //        GameObject obj = Instantiate(meteoritePrefab);
        //        obj.SetActive(false);
        //        meteoritePooledObjects.Add(obj);
        //    }
        //}
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
    public GameObject GetMonster1PooledObject()
    {
        Debug.Log(":::: " + monster1PooledObjects.Count);
        for (int i = 0; i < monster1PooledObjects.Count; i++)
        {
            if (!monster1PooledObjects[i].activeInHierarchy)
            {
                return monster1PooledObjects[i];
            }
        }
        return null;
    }
    public GameObject GetMonster2PooledObject()
    {
        for (int i = 0; i < monster2PooledObjects.Count; i++)
        {
            if (!monster2PooledObjects[i].activeInHierarchy)
            {
                return monster2PooledObjects[i];
            }
        }
        return null;
    }
    public GameObject GetMonster3PooledObject()
    {
        for (int i = 0; i < monster3PooledObjects.Count; i++)
        {
            if (!monster3PooledObjects[i].activeInHierarchy)
            {
                return monster3PooledObjects[i];
            }
        }
        return null;
    }
}

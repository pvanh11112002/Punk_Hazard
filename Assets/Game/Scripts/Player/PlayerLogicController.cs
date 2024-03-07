using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogicController : Character
{
    public GameObject[] posToSpawnMonster;
    public GameObject monsterPrefabs;
    public int timeToSpawnMonster = 3;
    // Start is called before the first frame update
    void Start()
    {
        hp = 300;
        InvokeRepeating("SpawnMonster", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if(hp < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    void SpawnMonster()
    {
        for(int i = 0; i < posToSpawnMonster.Length; i++)
        {
            var newGameObject = GameObject.Instantiate(monsterPrefabs, posToSpawnMonster[i].transform.position, Quaternion.identity);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogicController : MonoBehaviour
{
    public GameObject[] posToSpawnMonster;
    public GameObject monster;
    public int timeToSpawnMonster = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnMonster()
    {
        for(int i = 0; i < posToSpawnMonster.Length; i++)
        {
            var newGameObject = GameObject.Instantiate(monster, posToSpawnMonster[i].transform.position, Quaternion.identity);
        }
        
    }
}

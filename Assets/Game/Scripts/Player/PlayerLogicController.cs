using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogicController : Character
{
    public GameObject[] posToSpawnMonster;
    public GameObject monsterPrefabs;
    public int timeToSpawnMonster = 3;
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        hp = 300;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > timeToSpawnMonster)
        {
            elapsedTime = 0;
            SpawnMonster();
        }    
        if(hp < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    void SpawnMonster()
    {
        if(GameManager.Instance.gameState == GameState.GamePlay)
        {
            
            int rand = Random.Range(0, posToSpawnMonster.Length);
            var newGameObject = ObjPoolManager.Instance.GetMonster1PooledObject();
            if (newGameObject != null)
            {
                Debug.Log("Bắt đầu sinh quái");
                newGameObject.transform.position = posToSpawnMonster[rand].transform.position;
                newGameObject.SetActive(true);
            }
        }    
        
        
    }
}

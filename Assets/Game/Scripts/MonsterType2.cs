using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterType2 : Monster
{
    void Start()
    {
        this.hp = 30;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp > 0)
        {
            Move();
        }
        else
        {
            Instantiate(ObjPoolManager.Instance.explosionPrefab, this.transform.position, Quaternion.identity);
            GameObject temp = ObjPoolManager.Instance.GetExplosionPooledObject();
            if (temp != null)
            {
                temp.transform.position = this.transform.position;
            }
            OnDestroy();                   
        }

    }
}

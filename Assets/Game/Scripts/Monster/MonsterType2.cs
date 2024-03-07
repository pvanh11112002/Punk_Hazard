using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterType2 : Monster
{
    void Start()
    {
        this.hp = 70;
        this.speed = 1.25f;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (this.hp > 0)
        {
            Move();
        }
        else
        {
            GameObject explo = ObjPoolManager.Instance.GetExplosionPooledObject();
            if (explo != null)
            {
                explo.transform.position = this.transform.position;
                explo.SetActive(true);
            }
            OnDestroy();                   
        }
    }
}

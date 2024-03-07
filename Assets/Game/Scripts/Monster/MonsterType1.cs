using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterType1 : Monster
{
    void Start()
    {
        this.hp = 100;
        this.speed = 1;
    }

    void Update()
    {
        if (this.hp > 0)
        {
            Move();
        }
        else
        {
            OnDestroy();
        }        
    }
}

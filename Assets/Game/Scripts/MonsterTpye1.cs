using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTpye1 : Monster
{
    void Start()
    {
        this.hp = 100;
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
            OnDestroy();
        }
        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    hp -= 20;
    //}
}

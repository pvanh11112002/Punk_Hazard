using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    public GameObject player;
    protected float distance;
  
    protected void Move()
    {
        if (GameManager.Instance.gameState == GameState.GamePlay)
        {
            Vector2 dir = player.transform.position - transform.position;
            dir.Normalize();
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }    
          
    }    
}

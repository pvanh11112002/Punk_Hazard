using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsBullet : MonoBehaviour
{
    public float damage = 10f;
    private float elapsedTime;
    private float LifeTime = 2.5f;
    private void Update()
    {
        if(this.gameObject.activeInHierarchy)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime > LifeTime)
            {
                OnDespawn();
                elapsedTime = 0;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<PlayerLogicController>();
            player.MinusHP(damage);
            OnDespawn();
        }

    }
    private void OnDespawn()
    {
        gameObject.SetActive(false);
    }
}

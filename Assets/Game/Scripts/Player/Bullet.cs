using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 30;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            var mons = collision.gameObject.GetComponent<Monster>();
            mons.MinusHP(damage);
            OnDespawn();
        }
        else if(collision.gameObject.CompareTag("Wall"))
        {
            OnDespawn();
        }
    } 
    private void OnDespawn()
    {
        gameObject.SetActive(false);
    }
}

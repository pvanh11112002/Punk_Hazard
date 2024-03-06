using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosionDame = 30f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Monster"))
        {
            var mons = collision.gameObject.GetComponent<Monster>();
            mons.MinusHP(explosionDame);
        }       
    }
    public void OnDestroy()
    {
        this.gameObject.SetActive(false);
    }
}

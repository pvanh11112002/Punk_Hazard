using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Monster"))
        {
            var mons = collision.gameObject.GetComponent<Monster>();
            mons.OnDestroy();
            GameObject explo = ObjPoolManager.Instance.GetExplosionPooledObject();
            if (explo != null)
            {
                explo.transform.position = this.transform.position;
                explo.transform.position -= new Vector3(0, 5f, 0);
                explo.transform.localScale += new Vector3(5f, 5f, 5f);
                explo.SetActive(true);
            }
            OnDespawn();
        }
    }
   
    private void OnDespawn()
    {
        gameObject.SetActive(false);
    }
}

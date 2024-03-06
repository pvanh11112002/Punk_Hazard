using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float hp;
    protected float distance;
    
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    protected void Move()
    {
        //Ver1
        Vector2 dir = player.transform.position - transform.position;
        dir.Normalize();
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);  
        
        //Ver2: Duoi theo neu nguoi choi den gan quai
        //distance = Vector2.Distance(transform.position, player.transform.position);
        //Vector2 dir = player.transform.position - transform.position;
        //dir.Normalize();
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //if (distance < 4) 
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        //    transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        //}
    }
    protected void OnDestroy()
    {
        gameObject.SetActive(false);      
    }
    public void MinusHP(float damage)
    {
        hp -= damage;
    }
}

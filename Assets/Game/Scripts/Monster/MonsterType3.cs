using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterType3 : Monster
{
    public GameObject firePointOfMons;
    public float bulletForce;
    private float elapsedTime;
    private float timeBetweenFiringOfMons = 2;
    void Start()
    {
        this.hp = 30;
        this.speed = 1.5f;
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
            OnDestroy();
        }
        elapsedTime += Time.deltaTime;
        if(elapsedTime > timeBetweenFiringOfMons)
        {
            GetPosOfPlayer();
            elapsedTime = 0;
        }
    }
    private void GetPosOfPlayer()
    {
        //Vector2 playerPosRN = player.transform.position;
        GameObject monsBullet = ObjPoolManager.Instance.GetMonsterBulletPooledObject();
        if (monsBullet != null)
        {
            monsBullet.transform.position = firePointOfMons.transform.position;
            monsBullet.transform.rotation = firePointOfMons.transform.rotation;
            monsBullet.SetActive(true);
        }
        Rigidbody2D rb = monsBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePointOfMons.transform.right * bulletForce, ForceMode2D.Impulse);
    }

}

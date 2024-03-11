using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public Transform bulletTransform;
    public float bulletCount = 0;
    public float maxBulletOfRow;
    public float bulletForce = 20f;
    public bool canFire = true;

    private float timer;
    public float timeBetweenFiring;

    private float rechargingTimeElapsed = 0;
    public bool onRechargingTime = false;
    public float rechargingTimeMax;
    
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();      
    }
    void Update()
    {
        if(GameManager.Instance.gameState == GameState.GamePlay)
        {
            GetMousePos();
            if (!canFire)
            {
                timer += Time.deltaTime;
                if (timer > timeBetweenFiring)
                {
                    canFire = true;
                    timer = 0;
                }
            }
            if (onRechargingTime == true)
            {
                rechargingTimeElapsed += Time.deltaTime;
                if (rechargingTimeElapsed > rechargingTimeMax)
                {
                    onRechargingTime = false;
                    bulletCount = 0;
                    rechargingTimeElapsed = 0;
                }
            }
            if (canFire && Input.GetMouseButton(0) && onRechargingTime == false)
            {
                Firing();
            }
        }    
        
    }
    private void GetMousePos()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
    private void Firing()
    {
        if(bulletCount < maxBulletOfRow)
        {
            canFire = false;
            GameObject bullet = ObjPoolManager.Instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = bulletTransform.position;
                bullet.transform.rotation = bulletTransform.rotation;
                bullet.SetActive(true);
            }
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(bulletTransform.right * bulletForce, ForceMode2D.Impulse);
            bulletCount++;
        }
        else if(bulletCount >= maxBulletOfRow)
        {
            onRechargingTime = true;
            
        }
    }
}

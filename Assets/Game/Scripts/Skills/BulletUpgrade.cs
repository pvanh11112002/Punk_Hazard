using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class BulletUpgrade : Skill
{
    private float defaultNumOfBullet;
    private float defaultTimeBetweenFiring;
    private float defaultReloadTimes;
    private Transform getGun;
    private Shooting gun;
    public override void Active(GameObject parent)
    {
        getGun = parent.transform.GetChild(1);
        gun = getGun.GetComponent<Shooting>();
        defaultNumOfBullet = gun.maxBulletOfRow;
        defaultTimeBetweenFiring = gun.timeBetweenFiring;
        defaultReloadTimes = gun.rechargingTimeMax;
        gun.maxBulletOfRow = 16f;
        gun.timeBetweenFiring = 0.01f;
        gun.rechargingTimeMax = 1f;


    }
    public override void BeginCoolDown(GameObject parent)
    {
        getGun = parent.transform.GetChild(1);
        gun = getGun.GetComponent<Shooting>();
        gun.maxBulletOfRow = defaultNumOfBullet;
        gun.timeBetweenFiring = defaultTimeBetweenFiring;
        gun.rechargingTimeMax = defaultReloadTimes;
    }
}

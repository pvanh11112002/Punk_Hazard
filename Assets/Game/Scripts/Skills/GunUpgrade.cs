using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GunUpgrade : Skill
{
    private float defaultNumOfBullet;
    private float defaultReloadTimes;
    private Transform getGun;
    private Shooting gun;
    private float addNumOfBulltet = 4f;
    private float minusReloadTimes = 1f;
    public override void Active(GameObject parent)
    {
        getGun = parent.transform.GetChild(1);
        gun = getGun.GetComponent<Shooting>();
        defaultNumOfBullet = gun.maxBulletOfRow;
        defaultReloadTimes = gun.rechargingTimeMax;
        gun.maxBulletOfRow += addNumOfBulltet;
        gun.rechargingTimeMax -= minusReloadTimes;
    }
    public override void BeginCoolDown(GameObject parent)
    {
        getGun = parent.transform.GetChild(1);
        gun = getGun.GetComponent<Shooting>();
        gun.maxBulletOfRow = defaultNumOfBullet;
        gun.rechargingTimeMax = defaultReloadTimes;
    }
}

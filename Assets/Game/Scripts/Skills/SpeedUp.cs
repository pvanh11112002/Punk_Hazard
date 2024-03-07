using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpeedUp : Skill
{
    public float addSpeed;
    public float defaultSpeed;
    public override void Active(GameObject parent)
    {
        PlayerMovement speed = parent.GetComponent<PlayerMovement>();
        defaultSpeed = speed.moveSpeed;
        speed.moveSpeed += addSpeed;
    }
    public override void BeginCoolDown(GameObject parent)
    {
        PlayerMovement speed = parent.GetComponent<PlayerMovement>();
        speed.moveSpeed = defaultSpeed;
    }
}

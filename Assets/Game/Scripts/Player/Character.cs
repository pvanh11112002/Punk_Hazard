using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float hp;
    protected float speed;
    public void MinusHP(float damage)
    {
        hp -= damage;
    }
    public void OnDestroy()
    {
        gameObject.SetActive(false);
    }
}

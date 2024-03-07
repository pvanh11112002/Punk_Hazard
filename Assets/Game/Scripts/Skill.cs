using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : ScriptableObject
{
    public new string name;
    public float cooldownTime;
    public float activeTime;

    public virtual void Active(GameObject parent){ } //duuoc goi khi su dung ky nang, dùng virtual ?? khi dùng k? n?ng khác thì ghi ?è 
    public virtual void BeginCoolDown(GameObject parent) { }
}

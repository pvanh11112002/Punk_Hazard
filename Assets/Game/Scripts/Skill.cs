using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : ScriptableObject
{
    public new string name;
    public float cooldownTime;
    public float activeTime;

    public virtual void Active(GameObject parent){ } //duuoc goi khi su dung ky nang, d�ng virtual ?? khi d�ng k? n?ng kh�c th� ghi ?� 
    public virtual void BeginCoolDown(GameObject parent) { }
}

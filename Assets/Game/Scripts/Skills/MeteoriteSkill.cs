using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MeteoriteSkill : Skill
{
    //float elapsedSkillTime;
    //float elapsedTime;
    public float timeBetweenFalls = 3f;

    public override void Active(GameObject parent)
    {
        Transform playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        GameObject meteoriteTemp = ObjPoolManager.Instance.GetMeteoritePooledObject();
        if (meteoriteTemp != null)
        {
            meteoriteTemp.transform.position = playerPos.transform.position;
            meteoriteTemp.transform.position += new Vector3(0, 10f, 0);
            meteoriteTemp.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class SkillHolder : MonoBehaviour
{
    public Skill[] arrSkill;
    public Skill skill;
    public float test;
    float cooldownTime;
    float activeTime;
    enum SkillState
    {
        ready,
        active,
        cooldown
    }    
    SkillState state = SkillState.ready;
    public KeyCode key;
    private void Start()
    {
        skill = Resources.Load<Skill>("New Meteorite Skill");
        //if(test == 1)
        //{
        //    skill = arrSkill[0];
        //}    
    }
    void Update()
    {
        switch (state)
        {
            case SkillState.ready:
                if (Input.GetKeyDown(key))
                {
                    skill.Active(gameObject);
                    state = SkillState.active;
                    activeTime = skill.activeTime;
                }
                break;
            case SkillState.active:
                if(activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    skill.BeginCoolDown(gameObject);
                    state = SkillState.cooldown;
                    cooldownTime = skill.cooldownTime;
                }
                break;
            case SkillState.cooldown:
                if (cooldownTime > 0)
                {
                    cooldownTime -= Time.deltaTime;
                }
                else
                {
                    state = SkillState.ready;                  
                }
                break;
        }
    }
}

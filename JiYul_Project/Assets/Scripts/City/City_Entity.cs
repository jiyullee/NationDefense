using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Entity : MonoBehaviour
{
    private int startCost;

    City_Skill City_Skill;

    public int Cost { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; set; }
    public int SkillRange { get; set; }
    public int HealAmount { get; set; }

    private void Awake()
    {
        City_Skill = GetComponent<City_Skill>();
    }

    private void Start()
    {
        int skillTime = City_Skill.skill_Time;
        if (skillTime == 0)
            Cost = 1;
        else
        {
            Cost = skillTime;
        }
        startCost = Cost;
        HP = 0;
        MaxHP = 5;
        SkillRange = skillTime * 10;
    }

    private void OnGUI()
    {
        
    }
}

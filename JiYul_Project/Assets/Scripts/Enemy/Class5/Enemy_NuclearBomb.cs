using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_NuclearBomb : Enemy_Class_5
{
    override
    public void StartDisaster()
    {
        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        foreach (City_Damage city in cities)
        {
            city.Disaster = "핵폭탄";
            city.Disaster_Class = 5;
            city.Start_Disaster(damage);
        }
        LevelManager.Instance.IsRound = false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Great_Depression : Enemy_Class_4
{
    override
    public void StartDisaster()
    {
        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        foreach(City_Damage city in cities)
        {
            city.Disaster = "대공황";
            city.Disaster_Class = 4;
            city.Start_Disaster(damage);
        }
    }
}

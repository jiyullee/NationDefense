using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dust : Enemy_Class_4
{
    override
   public void StartDisaster()
    {
        Random.InitState((int)(Time.time * 100f));
        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        foreach (City_Damage city in cities)
        {
            int rand = Random.Range(0, 100);
            if (rand >= 80)
                continue;
            city.Disaster = "미세먼지";
            city.Disaster_Class = 4;
            city.Start_Disaster(damage);
        }

        LevelManager.Instance.IsRound = false;
    }
}

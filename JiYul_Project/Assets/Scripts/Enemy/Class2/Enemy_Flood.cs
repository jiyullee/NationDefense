using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Flood : Enemy_Class_2
{
    public override void StartDisaster()
    {
        Random.InitState((int)(Time.time * 100f));

        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        int randCount = Random.Range(0, enemyCount);
        int rand = Random.Range(0, cities.Length);
        infectedCity = cities[rand];
        infectedCity.Disaster_Class = 2;
        infectedCity.Disaster = "폭우";
        cities[rand].Start_Disaster(damage);

    }
}

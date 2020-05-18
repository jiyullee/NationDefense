using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Industrial_Disaster : Enemy_Class_1
{
    public override void StartDisaster()
    {
        StartCoroutine(Infect());
    }

    IEnumerator Infect()
    {
        Random.InitState((int)(Time.time * 100f));

        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        int randCount = Random.Range(1, enemyCount);
        for (int i = 0; i < randCount; i++)
        {
            int rand = Random.Range(0, cities.Length);
            infectedCity = cities[rand];
            infectedCity.Disaster_Class = 1;
            infectedCity.Disaster = "산업 재해";
            cities[rand].Start_Disaster(damage);
            yield return new WaitForSeconds(0.5f);
        }
    }
}

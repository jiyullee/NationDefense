using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dust : Enemy_Class_4
{/*
    public override void StartDisaster()
    {
        Random.InitState((int)(Time.time * 100f));

        City[] cities = FindObjectsOfType<City>();
        int randCount = Random.Range(0, enemyCount);
        int rand = Random.Range(0, cities.Length);
        infectedCity = cities[rand];
        infectedCity.Disaster_Class = 2;
        infectedCity.Disaster = "미세먼지";
        cities[rand].Infect_New();

        LevelManager.Instance.IsRound = false;
    }*/
}

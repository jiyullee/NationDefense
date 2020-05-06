using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Blackout : Enemy_Class_3
{
    public override void StartDisaster()
    {
        Random.InitState((int)(Time.time * 100f));

        City_Damage[] cities = FindObjectsOfType<City_Damage>();
        int rand = Random.Range(0, cities.Length);
        infectedCity = cities[rand];
        infectedCity.Disaster_Class = 3;
        infectedCity.Disaster = "정전";
        infectedCity.Start_Disaster(damage);

        StartCoroutine(Blackout());
    }

    IEnumerator Blackout()
    {
        Collider2D[] aroundCities = Physics2D.OverlapCircleAll(infectedCity.transform.position, 200f, layerMask);
        foreach (Collider2D aroundCity in aroundCities)
        {
            City_Damage city_Damage = aroundCity.GetComponentInParent<City_Damage>();
            city_Damage.Disaster_Class = 3;
            city_Damage.Disaster = "정전";
            city_Damage.Start_Disaster(damage);
            yield return new WaitForSeconds(0.1f);
        }
        LevelManager.Instance.IsRound = false;
    }
}

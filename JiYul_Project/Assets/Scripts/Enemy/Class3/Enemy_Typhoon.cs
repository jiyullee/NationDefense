using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Typhoon : Enemy_Class_3
{
    [SerializeField] Transform startPos;

    Vector3 originPos;
    private void Start()
    {
        originPos = transform.position;
    }
    public override void StartDisaster()
    {
        

        StartCoroutine(Typhoon());        
    }

    IEnumerator Typhoon()
    {
        Collider2D[] near_Cities = Physics2D.OverlapAreaAll(transform.position, transform.position + new Vector3(100, 100, 0), layerMask);
        while(near_Cities.Length > 0)
        {
            for(int i = 0; i < near_Cities.Length; i++)
            {
                City_Damage city = near_Cities[i].GetComponentInParent<City_Damage>();
                city.Disaster = "태풍";
                city.Disaster_Class = 3;
                city.Start_Disaster();
                yield return new WaitForSeconds(0.1f);
            }
            transform.Translate(100, 100, 0);
            near_Cities = Physics2D.OverlapAreaAll(transform.position, transform.position + new Vector3(100, 100, 0), layerMask);
        }
        LevelManager.Instance.IsRound = false;
        transform.position = originPos;
    }
}

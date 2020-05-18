using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_War : Enemy_Class_5
{
    [SerializeField] int radius;
    [SerializeField] Transform[] paths;
    bool[] isEnd = new bool[5];
    override
    public void StartDisaster()
    {
       for(int i = 0; i < paths.Length; i++)
        {
            int x = 0;
            int y = 0;
            if (i == 0)
            {
                x = 50; y = -20;
            }else if( i == 1)
            {
                x = 50; y = -50;
            }else if(i == 2)
            {
                x = 50; y = -70;
            }
            else if (i == 3)
            {
                x = 50; y = -100;
            }
            else if (i == 4)
            {
                x = -10; y = -120;
            }
            StartCoroutine(War_Path1(paths[i],x , y, i));
        }
    }

    IEnumerator War_Path1(Transform path, int posX, int posY, int index)
    {
        Collider2D[] aroundCities = Physics2D.OverlapCircleAll(path.position, radius, layerMask);
        while(aroundCities.Length > 0)
        {
            foreach (Collider2D aroundCity in aroundCities)
            {
                City_Damage city_Damage = aroundCity.GetComponentInParent<City_Damage>();
                city_Damage.Disaster_Class = 5;
                city_Damage.Disaster = "전쟁";
                city_Damage.Start_Disaster(damage);
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(0.1f);
            path.Translate(posX, posY, 0);
            //radius += 100;
            aroundCities = Physics2D.OverlapCircleAll(path.position, radius, layerMask);
        }

        isEnd[index] = true;
        CheckEnd();
    }
    

    private void CheckEnd()
    {
        for (int i = 0; i < isEnd.Length; i++)
        {
            if (isEnd[i])
            {
                                 
            }
            else
            {
                break;
            }
        }
    }
}

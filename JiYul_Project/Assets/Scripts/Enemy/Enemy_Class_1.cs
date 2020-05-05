using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy_Class_1 : Enemy
{
    private float[] weight;
    private Enemy_Class_1[] enemy_Class_1s;
    [SerializeField] protected int enemyCount;
    protected City_Damage infectedCity;
    private void Start()
    {
        weight = new float[]{ 15f,15f,15f,15f,15f,25f};
        enemy_Class_1s = new Enemy_Class_1[]{ FindObjectOfType<Enemy_Collapse>(), FindObjectOfType<Enemy_Explosion>(), FindObjectOfType<Enemy_Fire>(),
                                               FindObjectOfType<Enemy_Industrial_Disaster>(), FindObjectOfType<Enemy_Sinkhole>(), FindObjectOfType<Enemy_Traffic_Accident>() };
    }
    override
    public void SelectDisaster()
    {
        
        Random.InitState((int)(Time.time * 100f));

        float sum = 0;
        float rand = Random.Range(0, 100f);
        for(int i = 0; i < weight.Length; i++)
        {
            sum += weight[i];
            if(rand < sum)
            {
                enemy_Class_1s[i].StartDisaster();
                break;
            }
        }
    }

    virtual public void StartDisaster()
    {
        
    }
}

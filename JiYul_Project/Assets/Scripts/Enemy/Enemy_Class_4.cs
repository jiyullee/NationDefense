using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Class_4 : Enemy
{
    private float[] weight;
    private Enemy_Class_4[] enemy_Class_4s;
    [SerializeField] protected int enemyCount;
    [SerializeField] protected LayerMask layerMask;
    protected City_Damage infectedCity;
    private void Awake()
    {
        weight = new float[] { 100f, 0 };
        enemy_Class_4s = new Enemy_Class_4[] { FindObjectOfType<Enemy_Great_Depression>(), FindObjectOfType<Enemy_Dust>() };
    }
    override
    public void SelectDisaster()
    {

        Random.InitState((int)(Time.time * 100f));

        float sum = 0;
        float rand = Random.Range(0, 100.0f);
        for (int i = 0; i < weight.Length; i++)
        {
            sum += weight[i];
            if (rand <= sum)
            {
                enemy_Class_4s[i].StartDisaster();
                break;
            }
        }
    }

    virtual public void StartDisaster()
    {

    }
}

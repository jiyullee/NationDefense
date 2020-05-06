using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Class_5 : Enemy
{
    private float[] weight;
    private Enemy_Class_5[] enemy_Class_5s;
    [SerializeField] protected int enemyCount;
    [SerializeField] protected LayerMask layerMask;
    protected City_Damage infectedCity;
    private void Awake()
    {
        weight = new float[] { 100, 0, 0f };
        enemy_Class_5s = new Enemy_Class_5[] { FindObjectOfType<Enemy_AsteroidCrash>(), FindObjectOfType<Enemy_NuclearBomb>(), FindObjectOfType<Enemy_War>() };
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
                enemy_Class_5s[i].StartDisaster();
                break;
            }
        }
    }

    virtual public void StartDisaster()
    {

    }
}

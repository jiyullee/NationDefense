using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Class_2 : Enemy
{
    private float[] weight;
    private Enemy_Class_2[] enemy_Class_2s;
    [SerializeField] protected int enemyCount;
    protected City_Damage infectedCity;
    private void Start()
    {
        weight = new float[] { 15f, 15f, 15f, 15f, 15f, 25f };
        enemy_Class_2s = new Enemy_Class_2[]{ FindObjectOfType<Enemy_Drought>(), FindObjectOfType<Enemy_Earthquake>(), FindObjectOfType<Enemy_Epidemic>(),
                                               FindObjectOfType<Enemy_Forest_Fires>(), FindObjectOfType<Enemy_Flood>(), FindObjectOfType<Enemy_Heavy_Snow>() };
    }
    override
    public void SelectDisaster()
    {

        Random.InitState((int)(Time.time * 100f));

        float sum = 0;
        float rand = Random.Range(0, 100f);
        for (int i = 0; i < weight.Length; i++)
        {
            sum += weight[i];
            if (rand < sum)
            {
                enemy_Class_2s[i].StartDisaster();
                break;
            }
        }
    }

    virtual public void StartDisaster()
    {

    }
}

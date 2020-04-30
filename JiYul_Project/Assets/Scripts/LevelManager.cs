using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    private static LevelManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<LevelManager>();
            }
            return instance;
        }
    }

    private static int round;
    private int enemyCount = 1;
    private int damage = 1;

    private bool isStart;

    void Start()
    {
        round = 1;
    }

    public void OnClick_StartRound()
    {
        isStart = true;
        GameObject[] uninfected_Cities = GameObject.FindGameObjectsWithTag("Uninfect");
        GameObject[] infected_Cities = GameObject.FindGameObjectsWithTag("Infect");
        Random.InitState((int)(Time.time * 100f));
        enemyCount = round % 10;
        damage = enemyCount;

        for (int i = 0; i < enemyCount; i++)
        {
            if(uninfected_Cities.Length != 0)
            {
                int rand = Random.Range(0, uninfected_Cities.Length);
                uninfected_Cities[rand].GetComponent<City>().Infect_New();
            }
            
        }

        
        for (int i = 0; i < infected_Cities.Length; i++)
        {
            infected_Cities[i].GetComponent<City>().Infect_Old();

        }
    }

}

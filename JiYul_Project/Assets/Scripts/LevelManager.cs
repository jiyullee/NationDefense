using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance
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

    public float CurrentWaitRoundTime { get => currentWaitRoundTime; set => currentWaitRoundTime = value; }
    public bool IsRound { get => isRound; set => isRound = value; }
    public float TotalWaitRoundTime { get => totalWaitRoundTime; set => totalWaitRoundTime = value; }
    public int Round { get => round; set => round = value; }

    [SerializeField] private int round;
    private int enemyCount = 1;
    private int damage = 1;

    private bool isStart;
    private float currentWaitRoundTime;
    [SerializeField] private float totalWaitRoundTime;

    [SerializeField] private bool isRound;

    void Start()
    {
        round = 1;
        CanvasManager.Instance.SetRoundText(round);
        currentWaitRoundTime = TotalWaitRoundTime;
     
    }

    private void Update()
    {
        if (!isRound)
        {
            currentWaitRoundTime -= Time.deltaTime;
            if(currentWaitRoundTime <= 0)
            {
                StartRound();
                currentWaitRoundTime = totalWaitRoundTime;
            }
        }
    }

    public void StartRound()
    {
        CanvasManager.Instance.SetRoundText(++round);
        isRound = true;
        GameObject[] uninfected_Cities = GameObject.FindGameObjectsWithTag("Uninfect");
        GameObject[] infected_Cities = GameObject.FindGameObjectsWithTag("Infect");
        City[] cities = GameObject.FindObjectsOfType<City>();
        Random.InitState((int)(Time.time * 100f));
        enemyCount = round % 10;
        damage = enemyCount;

        for (int i = 0; i < enemyCount; i++)
        {
            if(cities.Length != 0)
            {
                int rand = Random.Range(0, cities.Length);
                cities[rand].Infect_New();
            }
            
        }

        /*
        for (int i = 0; i < infected_Cities.Length; i++)
        {
            infected_Cities[i].GetComponent<City>().Infect_Old(damage);

        }
        */
        currentWaitRoundTime = totalWaitRoundTime;
        isRound = false;
    }

}

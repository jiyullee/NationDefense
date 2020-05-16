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

    public bool IsRound { get => isRound; set => isRound = value; }
    public int Day { get => day; set => day = value; }
    public int Phase { get => phase; set => phase = value; }
    public int CurrentHour { get => currentHour; set => currentHour = value; }
    public float CurrentTime { get => currentTime; set => currentTime = value; }
    public float HoutPerSecond { get => houtPerSecond; set => houtPerSecond = value; }

    [SerializeField] private int phase;
    [SerializeField] private int day = 1;
    private int enemyCount = 1;
    private int damage = 1;
    private int daynightCount = 0;
    private bool isStart;

    [SerializeField] private bool isRound;
    [SerializeField] private int currentHour;
    [SerializeField] private float currentTime = 0;
    [SerializeField] private float houtPerSecond = 0;

    void Start()
    {
        CanvasManager.Instance.SetRoundText(day);    
    }

    private void Update()
    {
        if (!isRound)
        {
            currentTime += Time.deltaTime * houtPerSecond;
            if(currentTime >= 24)
            {
                currentTime = 0;
                StartDay();
            }
        }
        CurrentHour = (int)currentTime;
    }

    public void StartDay()
    {
        isRound = true;
        day++;
        CanvasManager.Instance.SetRoundText(day);
        CoinManager.Instance.IncreaseGold(5);

        GameObject[] infected_Cities = GameObject.FindGameObjectsWithTag("Infect");
        foreach(GameObject city in infected_Cities)
        {
            city.GetComponent<City_Damage>().Spread_Disaster();
        }
        
        SelectDisaster();
        currentTime = 0;
    }

    public void SelectDisaster()
    {
        Enemy_Class_1 enemy_Class_1 = FindObjectOfType<Enemy_Class_1>();
        Enemy_Class_2 enemy_Class_2 = FindObjectOfType<Enemy_Class_2>();
        Enemy_Class_3 enemy_Class_3 = FindObjectOfType<Enemy_Class_3>();
        Enemy_Class_4 enemy_Class_4 = FindObjectOfType<Enemy_Class_4>();
        Enemy_Class_5 enemy_Class_5 = FindObjectOfType<Enemy_Class_5>();
        if (day % 10 != 0)
        {
            enemy_Class_1.SelectDisaster();
        }
        else if (day == 10)
        {
            enemy_Class_2.SelectDisaster();

        }
        else if(day == 20)
        {
            enemy_Class_2.SelectDisaster();
        }else if(day == 30)
        {
            enemy_Class_3.SelectDisaster();
        }else if(day == 40)
        {
            enemy_Class_4.SelectDisaster();
        }else if(day == 50)
        {
            enemy_Class_5.SelectDisaster();
        }
    }
    

}

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
    public int Day { get => day; set => day = value; }
    public int Phase { get => phase; set => phase = value; }

    [SerializeField] private int phase;
    [SerializeField] private int day;
    private int enemyCount = 1;
    private int damage = 1;

    private bool isStart;
    private float currentWaitRoundTime;
    [SerializeField] private float totalWaitRoundTime;

    [SerializeField] private bool isRound;

    void Start()
    {
        day = 0;
        CanvasManager.Instance.SetRoundText(day);
        currentWaitRoundTime = TotalWaitRoundTime;
     
    }

    private void Update()
    {
        if (!isRound)
        {
            currentWaitRoundTime -= Time.deltaTime;
            if(currentWaitRoundTime <= 0)
            {
                StartDay();
                currentWaitRoundTime = totalWaitRoundTime;
            }
        }
    }

    public void StartDay()
    {
        isRound = true;
        day++;

        UI_CityInfo[] uI_CityInfos = FindObjectsOfType<UI_CityInfo>();
        foreach (var city in uI_CityInfos)
            city.gameObject.SetActive(false);

        GameObject[] infected_Cities = GameObject.FindGameObjectsWithTag("Infect");
        foreach(GameObject city in infected_Cities)
        {
            city.GetComponent<City_Damage>().IncreaseCount();
            city.GetComponent<City_Damage>().Spread_Disaster();
        }
        CanvasManager.Instance.SetRoundText(day);
        SelectDisaster();
    }

    public void SelectDisaster()
    {
        
        if (day % 10 != 0)
        {
            Enemy_Class_1 enemy_Class_1 = FindObjectOfType<Enemy_Class_1>();
            enemy_Class_1.SelectDisaster();
        }
        else if (day == 10)
        {
            Enemy_Class_2 enemy_Class_2 = FindObjectOfType<Enemy_Class_2>();
            enemy_Class_2.SelectDisaster();

        }
        else if(day == 20)
        {
            Enemy_Class_2 enemy_Class_2 = FindObjectOfType<Enemy_Class_2>();
            enemy_Class_2.SelectDisaster();
        }else if(day == 30)
        {
            Enemy_Class_3 enemy_Class_3 = FindObjectOfType<Enemy_Class_3>();
            enemy_Class_3.SelectDisaster();
        }else if(day == 40)
        {
            Enemy_Class_4 enemy_Class_4 = FindObjectOfType<Enemy_Class_4>();
            enemy_Class_4.SelectDisaster();
        }else if(day == 50)
        {

            Enemy_Class_5 enemy_Class_5 = FindObjectOfType<Enemy_Class_5>();
            enemy_Class_5.SelectDisaster();
        }
    }
    

}

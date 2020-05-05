using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Damage : MonoBehaviour
{
    City city;
    [SerializeField] private UI_CityInfo UI_CityInfo;
    [SerializeField] LayerMask layerMask;

    [SerializeField] private int disaster_Count = 0;
    [SerializeField] private int disaster_Class;
    [SerializeField] private string disaster;

    public int Disaster_Count { get => disaster_Count; set => disaster_Count = value; }
    public int Disaster_Class { get => disaster_Class; set => disaster_Class = value; }
    public string Disaster { get => disaster; set => disaster = value; }
    private void Awake()
    {
        city = GetComponent<City>();
    }

    public void Start_Disaster()
    {
        if (gameObject.layer == 8) // 미감염 
        {
            IncreaseCount();
            city.Damage = 5;
            gameObject.layer = 9;
            UI_CityInfo.SituationText.text = disaster;
        }
        else if (gameObject.layer == 10) // 안전
        {
            city.Hp -= LevelManager.Instance.Day % 10;
            if (city.Hp < 0)
            {
                IncreaseCount();
                city.Damage = LevelManager.Instance.Day % 10 - city.Hp;
                gameObject.layer = 9;
                UI_CityInfo.SituationText.text = disaster;
            }
            else if (city.Hp == 0)
            {
                gameObject.layer = 8;
            }
            else
            {
                UI_CityInfo.SituationText.text = "안전";
            }
        }else if(gameObject.layer == 9)
        {
            city.Damage += disaster_Class;
            if(city.Damage >= city.MaxDamage)
            {
                city.Damage = city.MaxDamage;
            }
        }
    }

    public void Spread_Disaster()
    {
        if (disaster_Class == 2)
        {
            Collider2D[] aroundCities = Physics2D.OverlapCircleAll(transform.position, 100f, layerMask);
            Random.InitState((int)(Time.time * 100f));

            if (aroundCities.Length == 0)
                return;

            int rand = Random.Range(0, aroundCities.Length);
            City_Damage city = aroundCities[rand].gameObject.GetComponentInParent<City_Damage>();
            city.disaster = disaster;
            city.disaster_Class = disaster_Class;
            city.Start_Disaster();
        }
        else if(disaster_Class == 3)
        {

        }

    }

    public void IncreaseCount()
    {
        disaster_Count++;
        if (disaster_Count % 5 == 0)
        {
            city.Damage++;
        }
        UI_CityInfo.Day_SituationText.text = disaster_Count.ToString() + "일차";
    }
}

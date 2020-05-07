using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Damage : MonoBehaviour
{
    City city;
    [SerializeField] private UI_CityInfo UI_CityInfo;
    [SerializeField] SpriteRenderer spriteRenderer;
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

    public void Start_Disaster(int damage)
    {
        if (gameObject.layer == 8) // 미감염 
        {
            Damage(damage);
        }
        else if (gameObject.layer == 10) // 안전
        {
            city.Hp -= damage;
            if (city.Hp < 0)
            {
                Damage(damage - city.Hp);
            }
            else if (city.Hp == 0)
            {
                UnDamage();
            }
            else
            {
                Safe();
            }
        }else if(gameObject.layer == 9)
        {
            More_Damage(damage);
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
            city.Start_Disaster(1);
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
            if (city.Damage >= city.MaxDamage)
            {
                city.Damage = city.MaxDamage;
            }
        }
        UI_CityInfo.DamageText.text = city.Damage.ToString();
        UI_CityInfo.Day_SituationText.text = disaster_Count.ToString() + "일차";
    }

    public void Damage(int damage)
    {
        gameObject.layer = 9;
        gameObject.tag = "Infect";
        spriteRenderer.color = Color.red;

        city.Hp = 0;
        city.Damage = damage;
        city.Cost += damage;
        UI_CityInfo.Infected(disaster, ++disaster_Count);       
    }

    public void More_Damage(int damage)
    {
        city.Damage += damage;
        if (city.Damage >= city.MaxDamage)
        {
            city.Damage = city.MaxDamage;
        }
        city.Cost += damage;
        
        UI_CityInfo.Infected(disaster, ++disaster_Count);
    }
    public void UnDamage()
    {
        gameObject.layer = 8;
        gameObject.tag = "Uninfect";
        spriteRenderer.color = Color.white;

        disaster_Count = 0;
        disaster = "";
        city.Hp = 0;
        city.Damage = 0;
        city.Cost = city.StartCost;
        UI_CityInfo.Uninfected();
    }

    public void Safe()
    {
        gameObject.layer = 10;
        gameObject.tag = "Taken";
        spriteRenderer.color = Color.blue;

        disaster_Count = 0;
        city.Damage = 0;
        city.Cost = city.StartCost;
        UI_CityInfo.Taken();
    }
}

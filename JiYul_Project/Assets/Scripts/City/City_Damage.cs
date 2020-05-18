using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Damage : MonoBehaviour
{
    City city;
    City_Entity City_Entity;
    [SerializeField] private UI_CityInfo UI_CityInfo;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] LayerMask layerMask;
    [SerializeField] private int disaster_Class;
    [SerializeField] private string disaster;

    public int Disaster_Class { get => disaster_Class; set => disaster_Class = value; }
    public string Disaster { get => disaster; set => disaster = value; }
    private void Awake()
    {
        city = GetComponent<City>();
        City_Entity = GetComponent<City_Entity>();
    }

    public void Start_Disaster(int damage)
    {
        DecreaseHP(damage);
        if(City_Entity.HP > 0)
        {
            Safe();
        }else if(City_Entity.HP == 0)
        {
            UnDamage();
        }
        else
        {
            Damage();
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

    public void Damage()
    {
        gameObject.layer = 9;
        gameObject.tag = "Infect";
        spriteRenderer.color = Color.red;

        UI_CityInfo.Infected(disaster);       
    }

    public void More_Damage(int damage)
    {
        DecreaseHP(damage);
        UI_CityInfo.Infected(disaster);
    }
    public void UnDamage()
    {
        gameObject.layer = 8;
        gameObject.tag = "Uninfect";
        spriteRenderer.color = Color.white;
        disaster = "";
        UI_CityInfo.Uninfected();
    }

    public void Safe()
    {
        gameObject.layer = 10;
        gameObject.tag = "Taken";
        spriteRenderer.color = Color.blue;
        UI_CityInfo.Taken();
    }

    public void IncreaseHP(int n)
    {
        if((n + City_Entity.HP) >= City_Entity.MaxHP)
        {
            City_Entity.HP = City_Entity.MaxHP;
        }
        else
            City_Entity.HP += n;
 
        UI_CityInfo.SetHP();
    }

    public void DecreaseHP(int n)
    {
        City_Entity.HP -= n;

        UI_CityInfo.SetHP();
    }
}

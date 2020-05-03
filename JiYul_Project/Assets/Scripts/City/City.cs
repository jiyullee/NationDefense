using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] private string stateName;
    [SerializeField] private string cityName;
    [SerializeField] LayerMask layerMask;

    [SerializeField] private int cost;
    [SerializeField] private int hp;
    [SerializeField] private int damage;
    [SerializeField] private int maxHP;
    [SerializeField] private int maxDamage;
    [SerializeField] private int _class;

    public int Damage { get => damage; set => damage = value; }
    public int Hp { get => hp; set => hp = value; }
    public string StateName { get => stateName; set => stateName = value; }
    public string CityName { get => cityName; set => cityName = value; }
    public int Cost { get => cost; set => cost = value; }
    public int MaxHP { get => maxHP; set => maxHP = value; }
    public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    public int Class { get => _class; set => _class = value; }

    private void Start()
    {
        string city_Class = cityName.Substring(cityName.Length - 1, 1);
        if (city_Class == "군")
            cost = 1;
        else if (stateName.Length != 0 && city_Class == "시")
            cost = 2;
        else if (stateName.Length == 0 && cityName != "서울특별시")
            cost = 3;
        else if (cityName == "서울특별시")
            cost = 4;
        _class = 1;
        maxHP = 5;
        maxDamage = 5;
        hp = maxHP;

    }

    public void Infect_New()
    {
        if(gameObject.layer == 8)
        {
            damage = maxDamage;
            gameObject.layer = 9;
        }
        else if(gameObject.layer == 10)
        {
            hp -= LevelManager.Instance.Round % 10;
            if(hp < 0)
            {
                damage = LevelManager.Instance.Round % 10 - hp;
                gameObject.layer = 9;
            }
            else if(hp == 0)
            {
                gameObject.layer = 8;
            }
        }
    }

    public void Infect_Old()
    {
        Collider2D[] aroundCities = Physics2D.OverlapCircleAll(transform.position, 50f, layerMask);
        Random.InitState((int)(Time.time * 100f));

        if (aroundCities.Length == 0)
            return;

        int rand = Random.Range(0, aroundCities.Length);
        aroundCities[rand].gameObject.GetComponentInParent<City>().Infect_New();

    }

    public void Buy()
    {
        gameObject.layer = 10;
        hp = 5;
    }

    public void Upgrade()
    {
        _class++;
        if(_class >= 4)
        {
            _class = 3;
            return;
        }

        if (gameObject.layer == 10)
        {
            if (_class == 2)
            {
                maxHP = 10;
            }
            else if (_class == 3)
            {
                maxHP = 15;
            }
        }
    }


}

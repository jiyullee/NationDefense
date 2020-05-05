using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] private UI_CityInfo UI_CityInfo;

    [SerializeField] private string stateName;
    [SerializeField] private string cityName;

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
    public int Class { get => _class; set => _class = value; }
    public int MaxDamage { get => maxDamage; set => maxDamage = value; }

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
        maxDamage = 50;
        hp = maxHP;

    }

    
    public void Buy()
    {
        gameObject.layer = 10;
        hp = 5;
        UI_CityInfo.SituationText.text = "안전";
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

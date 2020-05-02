using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City_CanvasManager : MonoBehaviour
{
    City city;
    [SerializeField] Button button;
    [SerializeField] protected Text nameText;

    private void Awake()
    {
        city = GetComponentInParent<City>();
    }
    public void OnClick_CityUI()
    {
        int damage = city.Damage;
        int hp = city.Hp;
        int cost = city.Cost;
        string cityName = city.CityName;
        string stateName = city.StateName;
        CanvasManager.Instance.Change_CityInfo(city.tag, cityName, stateName, hp, damage, cost);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] private string stateName;
    [SerializeField] private string cityName;
    [SerializeField] protected SpriteRenderer spriteRenderer;
    [SerializeField] LayerMask layerMask;

    private int cost;
    [SerializeField] private int hp;
    [SerializeField] private int damage;

    public int Damage { get => damage; set => damage = value; }
    public int Hp { get => hp; set => hp = value; }
    public string StateName { get => stateName; set => stateName = value; }
    public string CityName { get => cityName; set => cityName = value; }
    public int Cost { get => cost; set => cost = value; }

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
    }

    public void Infect_New(int damage)
    {
        this.Damage = damage;
        spriteRenderer.color = Color.red;
        gameObject.tag = "Infect";
        gameObject.layer = 8;
    }

    public void Infect_Old(int damage)
    {
        this.Damage = damage;
        Collider2D[] aroundCities = Physics2D.OverlapCircleAll(transform.position, 50f, layerMask);
        print(cityName + " " + aroundCities.Length);
        Random.InitState((int)(Time.time * 100f));

        if (aroundCities.Length == 0)
            return;

        int rand = Random.Range(0, aroundCities.Length);
        aroundCities[rand].gameObject.GetComponentInParent<City>().Infect_New(damage);

    }
}

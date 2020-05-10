using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    City_Damage city_Damage;

    [SerializeField] private UI_CityInfo UI_CityInfo;
    [SerializeField] private SpriteRenderer synergy_SR;
    [SerializeField] private string stateName;
    [SerializeField] private string cityName;

    [SerializeField] private int cost;
    [SerializeField] private int hp;
    [SerializeField] private int damage;
    [SerializeField] private int maxHP;
    [SerializeField] private int maxDamage;
    [SerializeField] private int _class;
    [SerializeField] private int upgradeCost;
    [SerializeField] private int startCost;

    [SerializeField] private City_Synergy city_Synergy;

    public int Damage { get => damage; set => damage = value; }
    public int Hp { get => hp; set => hp = value; }
    public string StateName { get => stateName; set => stateName = value; }
    public string CityName { get => cityName; set => cityName = value; }
    public int Cost { get => cost; set => cost = value; }
    public int MaxHP { get => maxHP; set => maxHP = value; }
    public int Class { get => _class; set => _class = value; }
    public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    public int StartCost { get => startCost; set => startCost = value; }
    public int UpgradeCost { get => upgradeCost; set => upgradeCost = value; }
    public City_Synergy City_Synergy { get => city_Synergy; set => city_Synergy = value; }

    private void Awake()
    {
        city_Synergy = GetComponent<City_Synergy>();
        city_Damage = GetComponent<City_Damage>();
    }
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
        startCost = cost;
        _class = 1;
        maxHP = 5;
        maxDamage = 50;
        hp = maxHP;

    }

    
    public void Buy()
    {
        if (CoinManager.Instance.Gold >= cost)
        {
            CoinManager.Instance.Gold -= cost;
            CanvasManager.Instance.SetCoinText(CoinManager.Instance.Gold);
        }
        else
            return;
        hp = 5;
        city_Damage.Safe();
        
    }

    public void Upgrade()
    {
        if (CoinManager.Instance.Gold >= upgradeCost)
        {
            CoinManager.Instance.Gold -= upgradeCost;
            CanvasManager.Instance.SetCoinText(CoinManager.Instance.Gold);
        }
        else
            return;

        _class++;
        if(_class >= 4)
        {
            _class = 3;
        }

        if (_class == 2)
        {
            maxHP = 10;
            hp = maxHP;
        }
        else if (_class == 3)
        {
            maxHP = 15;
            hp = maxHP;
            UI_CityInfo.UpgradeBtn.gameObject.SetActive(false);
        }
        UI_CityInfo.SetHP();
    }

    public void SelectSynergy(string stateName)
    {
        if(this.stateName == stateName)
        {
            synergy_SR.gameObject.SetActive(true);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
    [SerializeField] private string stateName;
    [SerializeField] private string cityName;
    [SerializeField] private int _class = 1;

    [SerializeField] private SpriteRenderer[] sr_Synergies;

    public string StateName { get => stateName; set => stateName = value; }
    public string CityName { get => cityName; set => cityName = value; }

    public int Class { get => _class; set => _class = value; }
    public City_Synergy City_Synergy { get; set; }
    [SerializeField] private UI_CityInfo UI_CityInfo;
    private City_Damage City_Damage;
    private City_Entity City_Entity;


    private void Awake()
    {
        City_Synergy = GetComponent<City_Synergy>();
        City_Damage = GetComponent<City_Damage>();
        City_Entity = GetComponent<City_Entity>();
    }
    
    public void Buy()
    {
        if (CoinManager.Instance.Gold >= City_Entity.Cost)
        {
            CoinManager.Instance.Gold -= City_Entity.Cost;
            CanvasManager.Instance.SetCoinText(CoinManager.Instance.Gold);
        }
        else
            return;
        City_Entity.HP = City_Entity.MaxHP;
        City_Damage.Safe();
        
    }

    public void Upgrade()
    {
        if (CoinManager.Instance.Gold >= City_Entity.Cost)
        {
            CoinManager.Instance.Gold -= City_Entity.Cost;
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
            City_Entity.MaxHP = 10;
            City_Entity.HP = City_Entity.MaxHP;
        }
        else if (_class == 3)
        {
            City_Entity.MaxHP = 15;
            City_Entity.HP = City_Entity.MaxHP;
            UI_CityInfo.UpgradeBtn.gameObject.SetActive(false);
        }
        UI_CityInfo.SetHP();
    }

    public void SelectedSynergy()
    {
        foreach(var sr in sr_Synergies)
        {
            sr.color = Color.yellow;
        }
    }

    public void UnSelectedSynergy()
    {
        foreach (var sr in sr_Synergies)
        {
            sr.color = Color.black;
        }
    }
}

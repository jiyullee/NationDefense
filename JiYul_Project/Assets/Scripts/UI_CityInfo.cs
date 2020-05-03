using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_CityInfo : MonoBehaviour
{
    [SerializeField] private Text stateText;
    [SerializeField] private Text nameText;
    [SerializeField] private Text costText;
    [SerializeField] private Text hpText;
    [SerializeField] private Text damageText;
    [SerializeField] Button buyBtn;
    [SerializeField] Button upgradeBtn;
    [SerializeField] private GameObject hpObj;
    [SerializeField] private GameObject damageObj;


    City city;
    Image damageImg;
    Image hpImg;
    private void Awake()
    {
        city = GetComponentInParent<City>();
        damageImg = damageObj.GetComponentInChildren<Image>();
        hpImg = hpObj.GetComponentInChildren<Image>();
    }

    private void Update()
    {
        // 8 - 미감염, 9 - 감염, 10 - 구매
        if(city.gameObject.layer == 8)
        {
            Uninfected();
        }
        else if(city.gameObject.layer == 9)
        {
            Infected();
        }else if(city.gameObject.layer == 10)
        {
            Taken();
        }
    }

    private void Uninfected()
    {
        buyBtn.gameObject.SetActive(true);
        upgradeBtn.gameObject.SetActive(false);
        hpObj.SetActive(false);
        damageObj.SetActive(false);
        
    }
    private void Infected()
    {
        buyBtn.gameObject.SetActive(true);
        upgradeBtn.gameObject.SetActive(false);
        hpObj.SetActive(false);
        damageObj.SetActive(true);
        damageImg.fillAmount = (float)city.Damage / city.MaxDamage;
        damageText.text = city.Damage + "/" + city.MaxDamage;
    }

    private void Taken()
    {
        buyBtn.gameObject.SetActive(false);
        upgradeBtn.gameObject.SetActive(true);
        hpObj.SetActive(true);
        damageObj.SetActive(false);
        hpImg.fillAmount = (float)city.Hp / city.MaxHP;
        hpText.text = city.Hp + "/" + city.MaxHP;
    }

    public void SetInfo()
    {
        stateText.text = city.StateName;
        nameText.text = city.CityName;
        costText.text = city.Cost.ToString();
        
    }

    public void OnClick_BuyCity()
    {
        buyBtn.gameObject.SetActive(false);
        city.Buy();
    }

    public void OnClick_Upgrade()
    {
        city.Upgrade();
    }
    
}

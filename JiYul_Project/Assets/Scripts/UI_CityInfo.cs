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
    [SerializeField] private Text situationText;
    [SerializeField] private Text day_SituationText;
    [SerializeField] Button buyBtn;
    [SerializeField] Button upgradeBtn;
    [SerializeField] private GameObject hpObj;
    [SerializeField] private GameObject damageObj;


    [SerializeField] private City city;
    [SerializeField] private Image damageImg;
    [SerializeField] private Image hpImg;

    public Text SituationText { get => situationText; set => situationText = value; }
    public Text Day_SituationText { get => day_SituationText; set => day_SituationText = value; }
    public Text DamageText { get => damageText; set => damageText = value; }

    private void OnEnable()
    {
        costText.text = city.Cost.ToString();
    }
    public void Uninfected()
    {
        buyBtn.gameObject.SetActive(true);
        upgradeBtn.gameObject.SetActive(false);
        hpObj.SetActive(false);
        damageObj.SetActive(false);
        costText.text = city.Cost.ToString();
        situationText.text = "";
        day_SituationText.gameObject.SetActive(false);
    }

    public void Infected(string disaster, int disasterCount)
    {
        buyBtn.gameObject.SetActive(true);
        upgradeBtn.gameObject.SetActive(false);
        hpObj.SetActive(false);
        damageObj.SetActive(true);
        damageImg.fillAmount = city.Damage / city.MaxDamage;
        damageText.text = city.Damage + "/" + city.MaxDamage;
        costText.text = city.Cost.ToString();
        situationText.text = disaster;
        day_SituationText.text = "위험" + disasterCount.ToString() + "일차";
    }

    public void Taken()
    {
        buyBtn.gameObject.SetActive(false);
        upgradeBtn.gameObject.SetActive(true);
        hpObj.SetActive(true);
        damageObj.SetActive(false);
        day_SituationText.gameObject.SetActive(false);
        hpImg.fillAmount = (float)city.Hp / city.MaxHP;
        hpText.text = city.Hp + "/" + city.MaxHP;
        costText.text = city.Cost.ToString();
        situationText.text = "안전";
    }

    public void SetInfo()
    {
        stateText.text = city.StateName;
        nameText.text = city.CityName;
        costText.text = city.Cost.ToString();
        
    }

    public void OnClick_BuyCity()
    {
        city.Buy();       
    }

    public void OnClick_Upgrade()
    {
        city.Upgrade();
    }
    
}

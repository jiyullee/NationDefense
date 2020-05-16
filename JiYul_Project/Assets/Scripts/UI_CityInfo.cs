using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_CityInfo : MonoBehaviour
{
    [SerializeField] private City city;

    [SerializeField] Button btn_Buy;
    [SerializeField] Button btn_Upgrade;
    [SerializeField] private GameObject obj_HP;
    [SerializeField] private GameObject obj_Damage;
    [SerializeField] private GameObject obj_SkillTooltip;
    [SerializeField] private Text text_State;
    [SerializeField] private Text text_City;
    [SerializeField] private Text text_Cost;
    [SerializeField] private Text text_UpgradeCost;
    [SerializeField] private Text text_Disaster;
    [SerializeField] private Text text_HP;
    [SerializeField] private Text text_Damage;
    [SerializeField] private Image image_HP;

    public Text SituationText { get => text_Disaster; set => text_Disaster = value; }
    public Text DamageText { get => text_Damage; set => text_Damage = value; }
    public Button UpgradeBtn { get => btn_Upgrade; set => btn_Upgrade = value; }
    public Text HpText { get => text_HP; set => text_HP = value; }

    private void OnEnable()
    {
        text_Cost.text = city.Cost.ToString();
        text_UpgradeCost.text = city.UpgradeCost.ToString();
    }
    public void Uninfected()
    {
        btn_Buy.gameObject.SetActive(true);
        btn_Upgrade.gameObject.SetActive(false);
        obj_HP.SetActive(false);
        obj_Damage.SetActive(false);
        text_Cost.text = city.Cost.ToString();
        text_Disaster.text = "";
    }

    public void Infected(string disaster)
    {
        btn_Buy.gameObject.SetActive(true);
        btn_Upgrade.gameObject.SetActive(false);
        obj_HP.SetActive(false);
        obj_Damage.SetActive(true);
        text_Damage.text = city.Damage + "/" + city.MaxDamage;
        text_Cost.text = city.Cost.ToString();
        text_Disaster.text = disaster;
    }

    public void Taken()
    {
        btn_Buy.gameObject.SetActive(false);
        btn_Upgrade.gameObject.SetActive(true);
        obj_HP.SetActive(true);
        obj_Damage.SetActive(false);
        image_HP.fillAmount = (float)city.Hp / city.MaxHP;
        text_HP.text = city.Hp + "/" + city.MaxHP;
        text_Cost.text = city.Cost.ToString();
        text_Disaster.text = "안전";
    }

    public void SetInfo()
    {
        text_State.text = city.StateName;
        text_City.text = city.CityName;
        text_Cost.text = city.Cost.ToString();
        
    }

    public void OnClick_BuyCity()
    {
        city.Buy();       
    }

    public void OnClick_Upgrade()
    {
        city.Upgrade();
    }

    public void OnClick_ShowSkill()
    {
        if(obj_SkillTooltip.activeSelf)
            obj_SkillTooltip.SetActive(false);
        else
            obj_SkillTooltip.SetActive(true);
    }

    public void SetHP()
    {
        image_HP.fillAmount = (float)city.Hp / city.MaxHP;
        text_HP.text = city.Hp + "/" + city.MaxHP;
    }

    private void OnDisable()
    {
        obj_SkillTooltip.gameObject.SetActive(false);
    }

}

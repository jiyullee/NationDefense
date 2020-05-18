using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_CityInfo : MonoBehaviour
{
    [SerializeField] private City city;
    [SerializeField] private City_Entity City_Entity;
    [SerializeField] private City_Skill city_Skill;
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
    [SerializeField] private Text text_Skill;
    [SerializeField] private Text text_SkillRange;
    [SerializeField] private Text text_SkillTime;
    [SerializeField] private Image image_HP;

    public Text SituationText { get => text_Disaster; set => text_Disaster = value; }
    public Text DamageText { get => text_Damage; set => text_Damage = value; }
    public Button UpgradeBtn { get => btn_Upgrade; set => btn_Upgrade = value; }
    public Text HpText { get => text_HP; set => text_HP = value; }
    public Text Text_SkillRange { get => text_SkillRange; set => text_SkillRange = value; }

    private void OnEnable()
    {
        text_Cost.text = City_Entity.Cost.ToString();
        text_UpgradeCost.text = City_Entity.Cost.ToString();
        text_SkillRange.text = City_Entity.SkillRange.ToString();
        int skill_Time = city_Skill.skill_Time;

        if (skill_Time == 0)
        {
            obj_SkillTooltip.transform.parent.gameObject.SetActive(false);
        }
        else if(1<= skill_Time && skill_Time <= 11)
        {
            text_Skill.text = "AM";
            text_SkillTime.text = skill_Time.ToString();
        }
        else if (12 <= skill_Time && skill_Time <= 23)
        {
            text_Skill.text = "PM";
            text_SkillTime.text = skill_Time.ToString();
        }

    }
    public void Uninfected()
    {
        btn_Buy.gameObject.SetActive(true);
        btn_Upgrade.gameObject.SetActive(false);
        obj_HP.SetActive(false);
        obj_Damage.SetActive(false);
        text_Cost.text = City_Entity.Cost.ToString();
        text_Disaster.text = "";
    }

    public void Infected(string disaster)
    {
        btn_Buy.gameObject.SetActive(true);
        btn_Upgrade.gameObject.SetActive(false);
        obj_HP.SetActive(false);
        obj_Damage.SetActive(true);
        text_Damage.text = Mathf.Abs(City_Entity.HP).ToString();
        text_Cost.text = City_Entity.Cost.ToString();
        text_Disaster.text = disaster;
    }

    public void Taken()
    {
        btn_Buy.gameObject.SetActive(false);
        btn_Upgrade.gameObject.SetActive(true);
        obj_HP.SetActive(true);
        obj_Damage.SetActive(false);
        image_HP.fillAmount = (float)City_Entity.HP / City_Entity.MaxHP;
        text_HP.text = City_Entity.HP + "/" + City_Entity.MaxHP;
        text_Cost.text = City_Entity.Cost.ToString();
        text_Disaster.text = "안전";
    }

    public void SetInfo()
    {
        text_State.text = city.StateName;
        text_City.text = city.CityName;
        text_Cost.text = City_Entity.Cost.ToString();
        
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
        image_HP.fillAmount = (float)City_Entity.HP / City_Entity.MaxHP;
        text_HP.text = City_Entity.HP + "/" + City_Entity.MaxHP;
    }

    public void OnClick_ShowSkillRange()
    {
        CanvasManager.Instance.OnSkillRange(city.gameObject.transform.position, City_Entity.SkillRange);
    }

    private void OnDisable()
    {
        obj_SkillTooltip.gameObject.SetActive(false);
    }

}

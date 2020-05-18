using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM1 : Skill
{
    public override void ChooseSkill(City city)
    {
        if(city.CityName == "김제시")
        {
            new Skill_Gimje().UseSkill();
        }else if (city.CityName == "남원시")
        {
            new Skill_Namwon().UseSkill();
        }
        else if (city.CityName == "속초시")
        {
            new Skill_Sokcho().UseSkill();
        }
        else if (city.CityName == "문경시")
        {
            new Skill_Moongyeong().UseSkill();
        }
        else if (city.CityName == "삼척시")
        {
            new Skill_Samcheok().UseSkill();
        }
        else if (city.CityName == "과천시")
        {
            new Skill_Gwacheon().UseSkill();
        }
        else if (city.CityName == "태백시")
        {
            new Skill_Taebaek().UseSkill();
        }
        else if (city.CityName == "계룡시")
        {
            new Skill_Gyeryong().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Gimje : Skill_AM1
{

    public override void UseSkill()
    {
        Random.InitState((int)(Time.time * 100f));
        GameObject[] safe_cities = GameObject.FindGameObjectsWithTag("Taken");
        int rand = Random.Range(0, safe_cities.Length);
        safe_cities[rand].GetComponent<City_Damage>().IncreaseHP(1);
    }
}

public class Skill_Namwon : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Sokcho : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Moongyeong : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Samcheok : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gwacheon : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Taebaek : Skill_AM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gyeryong : Skill_AM1
{

    public override void UseSkill()
    {

    }
}


